using Mono.Cecil;
using Mono.Cecil.Cil;
using System;
using System.IO;
using System.Linq;

namespace ReflectionBindingGenerator
{
    public class CecilBindingGenerator
    {
        public string ManagedDirectory;
        public string OutputDirectory;
        ModuleDefinition SrcModule;
        ModuleDefinition DestModule;
        static string[] BlacklistNamespaces = new string[]
        {
            "TriangleNet",
            "MeshCombineStudio",
            "MagicaCloth",
            "LuxParticles",
            "csDelaunay",
            "AwesomeTechnologies",
            "AK"
        };
        const string Namespace = "SolastaModApi.ReflectionBindings";
        public CecilBindingGenerator(string assemblyPath, string outputDirectory)
        {
            ManagedDirectory = Path.GetDirectoryName(assemblyPath);
            OutputDirectory = outputDirectory;
            SrcModule = ModuleDefinition.ReadModule(assemblyPath);
            DestModule = ModuleDefinition.CreateModule("ReflectionBindings", ModuleKind.Dll);
            SetIgnoreAccessChecks();
        }
        public void SetIgnoreAccessChecks()
        {
            var ignoreAccessAttribute = typeof(System.Runtime.CompilerServices.IgnoresAccessChecksToAttribute)
                    .GetConstructor(new Type[] { typeof(string) });
            var ignoreAccessAttributeRef = DestModule.ImportReference(ignoreAccessAttribute);
            CustomAttribute caAccess = 
                new CustomAttribute(ignoreAccessAttributeRef);
            caAccess.ConstructorArguments.Add(new CustomAttributeArgument(DestModule.TypeSystem.String, SrcModule.Assembly.Name.Name));
            DestModule.Assembly.CustomAttributes.Add(caAccess);
        }
        public static bool IsStatic(TypeDefinition type)
        {
            return type.IsSealed && type.IsAbstract;
        }
        public bool IsValidType(TypeDefinition type)
        {
            if (type.Name == "<Module>" || type.Name == "<PrivateImplementationDetails>") return false;
            if (type.HasGenericParameters) return false; //Generic class
            if (IsStatic(type)) return false;
            if (!type.IsPublic) return false;
            foreach(var prefix in BlacklistNamespaces)
            {
                if (type.Namespace.StartsWith(prefix)) return false;
            }
            if (!type.Fields.Any(IsValidField)) return false;
            return true;
        }

        static bool IsValidField(FieldDefinition field)
        {
            if (field.IsStatic) return false;
            if (field.IsPublic) return false;
            if (field.Name.EndsWith("BackingField")) return false;
            //var concreteType = IlSpyUtil.GetConcreteType(field.Type);
            //if(IlSpyUtil.IterateType(field.Type).Any(t => t.Accessibility != Accessibility.Public))
            //{
            //    return false;
            //}
            return true;
        }
        public void GenerateBindings()
        {
            var toProccess = SrcModule
                    .Types
                    .Where(IsValidType);
            foreach(var type in toProccess)
            {
                WriteType(type);
            }
            DestModule.Write(Path.Combine(OutputDirectory, "ReflectionBindings.dll"));
#if DEBUG
            var decompiler = new ICSharpCode.Decompiler.CSharp.CSharpDecompiler(
                Path.Combine(OutputDirectory, "ReflectionBindings.dll"), 
                new IlspyAssemblyResolver(ManagedDirectory),
                new ICSharpCode.Decompiler.DecompilerSettings()
            {
                UsingDeclarations = false
            });
            File.WriteAllText(Path.Combine(OutputDirectory, "ReflectionBindings.cs"), decompiler.DecompileWholeModuleAsString());
#endif
        }
        public void WriteType(TypeDefinition type)
        {
            var newType = new TypeDefinition(Namespace, $"{type.Name}Bindings",
                    TypeAttributes.Class | TypeAttributes.Sealed | TypeAttributes.Abstract | TypeAttributes.Public | TypeAttributes.BeforeFieldInit, DestModule.TypeSystem.Object);
            DestModule.Types.Add(newType);
            
            var extentionAttributeConstructorRef = DestModule.ImportReference(
                typeof(System.Runtime.CompilerServices.ExtensionAttribute).GetConstructor(Type.EmptyTypes));
            newType.CustomAttributes.Add(new CustomAttribute(extentionAttributeConstructorRef));
            foreach (var field in type.Fields.Where(IsValidField))
            {
                WriteAccessor(newType, field);
            }
        }

        public void WriteAccessor(TypeDefinition bindingType, FieldDefinition field)
        {
            var fieldRef = DestModule.ImportReference(field);
            var fieldTypeRef = DestModule.ImportReference(field.FieldType);
            var declaringTypeRef = DestModule.ImportReference(field.DeclaringType);
            if (field.DeclaringType.IsValueType)
            {
                declaringTypeRef = new ByReferenceType(declaringTypeRef);
            }
            var extentionAttributeConstructorRef = DestModule.ImportReference(
                typeof(System.Runtime.CompilerServices.ExtensionAttribute).GetConstructor(Type.EmptyTypes));
            var setMethod = new MethodDefinition($"Set{field.Name.FirstCharToUpper()}",
                MethodAttributes.Public | MethodAttributes.Static, DestModule.TypeSystem.Void);
            bindingType.Methods.Add(setMethod);
            setMethod.CustomAttributes.Add(new CustomAttribute(extentionAttributeConstructorRef));
            var instanceParameter = new ParameterDefinition("instance", ParameterAttributes.None, declaringTypeRef);
            setMethod.Parameters.Add(instanceParameter);

            var valueParameter = new ParameterDefinition("value", ParameterAttributes.None, fieldTypeRef);
            setMethod.Parameters.Add(valueParameter);

            var il = setMethod.Body.GetILProcessor();
            il.Append(il.Create(OpCodes.Ldarg_0));
            il.Append(il.Create(OpCodes.Ldarg_1));
            il.Append(il.Create(OpCodes.Stfld, fieldRef));
            il.Append(il.Create(OpCodes.Ret));

            var getmethod = new MethodDefinition($"Get{field.Name.FirstCharToUpper()}",
                MethodAttributes.Public | MethodAttributes.Static, fieldTypeRef);
            bindingType.Methods.Add(getmethod);

            getmethod.CustomAttributes.Add(new CustomAttribute(extentionAttributeConstructorRef));

            getmethod.Parameters.Add(instanceParameter);

            il = getmethod.Body.GetILProcessor();
            il.Append(il.Create(OpCodes.Ldarg_0));
            il.Append(il.Create(OpCodes.Ldfld, fieldRef));
            il.Append(il.Create(OpCodes.Ret));
        }
    }
}
