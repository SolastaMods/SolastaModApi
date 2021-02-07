using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.CSharp.Syntax;
using ICSharpCode.Decompiler.TypeSystem;
using System.IO;
using System.Linq;

namespace ReflectionBindingGenerator
{
    public class IlSpyBindingGenerator
    {
        public string OutputDirectory;
        CSharpDecompiler Decompiler;
        bool SingleFile = true;
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
        public IlSpyBindingGenerator(string assemblyPath, string outputDirectory)
        {
            OutputDirectory = outputDirectory;
            Decompiler = new CSharpDecompiler(assemblyPath, new DecompilerSettings()
            {
                UsingDeclarations = !SingleFile
            });
        }
        public string GenerateFileName(ITypeDefinition type)
        {
            string validName = "";
            if (type.Namespace != "")
            {
                validName += type.Namespace + ".";
            }
            validName += type.Name;
            return Path.Combine(OutputDirectory, $"{validName}.cs");
        }

        public bool IsValidType(ITypeDefinition type)
        {
            if (type.Name == "<Module>" || type.Name == "<PrivateImplementationDetails>") return false;
            if (type.TypeParameterCount > 0) return false; //Generic class
            if (type.IsStatic) return false;
            if (type.Accessibility != Accessibility.Public) return false;
            foreach(var prefix in BlacklistNamespaces)
            {
                if (type.Namespace.StartsWith(prefix)) return false;
            }
            if (!type.Fields.Any(IsValidField)) return false;
            return true;
        }

        static bool IsValidField(IField field)
        {
            if (field.IsStatic) return false;
            if (field.Accessibility == Accessibility.Public) return false;
            if (field.Name.EndsWith("BackingField")) return false;
            var concreteType = IlSpyUtil.GetConcreteType(field.Type);
            if(IlSpyUtil.IterateType(field.Type).Any(t => t.Accessibility != Accessibility.Public))
            {
                return false;
            }
            return true;
        }

        public TypeInfo GerateTypeInfo(ITypeDefinition type)
        {
            var typeInfo = new TypeInfo();
            typeInfo.TypeDef = type;
            typeInfo.Name = type.Name;
            typeInfo.ClassType = type.FullTypeName.ToString();
            typeInfo.Filepath = GenerateFileName(type);
            foreach (var field in type.Fields.Where(IsValidField))
            {
                var syntaxTree = Decompiler.Decompile(field.MetadataToken);
                var decl = syntaxTree.Children.OfType<FieldDeclaration>().Single();
                foreach(var usingDecl in syntaxTree.Children.OfType<UsingDeclaration>())
                {
                    typeInfo.UsingStatements.Add(usingDecl.ToString().Trim());
                }
                var fieldType = decl.Children.OfType<AstType>().Single();
                var fieldInitalizer = decl.Children.OfType<VariableInitializer>().Single();
                var fieldIdentifier = fieldInitalizer.Children.OfType<Identifier>().Single();
                typeInfo.Fields.Add(new FieldInfo(typeInfo, fieldType.ToString(), fieldIdentifier.ToString()));
            }
            return typeInfo;
        }
        public void GenerateBindings()
        {
            var toProccess = Decompiler.TypeSystem.MainModule.TopLevelTypeDefinitions
                .Where(IsValidType)
                .Select(GerateTypeInfo);
            if (SingleFile)
            {
                using (var sw = new StreamWriter(Path.Combine(OutputDirectory, "ReflectionBindings.cs")))
                using (var w = new IndentedWriter(sw))
                {
                    foreach (var usingDecl in toProccess.SelectMany(ti => ti.UsingStatements).Distinct())
                    {
                        w.WriteLine(usingDecl);
                    }
                    w.WriteLine("namespace {0}", Namespace);
                    w.WriteLine("{");
                    w.IndentLevel++;
                    foreach (var typeInfo in toProccess)
                    {
                        WriteType(typeInfo, w);
                    }
                    w.IndentLevel--;
                    w.WriteLine("}");
                }
            }
            else
            {
                foreach (var typeInfo in toProccess)
                {
                    using (var sw = new StreamWriter(typeInfo.Filepath))
                    using(var w = new IndentedWriter(sw))
                    {
                        WriteTypeSingleFile(typeInfo, w);
                    }
                }
            }
        }

        public void WriteTypeSingleFile(TypeInfo type, IndentedWriter w)
        {
            foreach (var usingDecl in type.UsingStatements)
            {
                w.WriteLine(usingDecl);
            }
            w.WriteLine("namespace {0}", Namespace);
            w.WriteLine("{");
            w.IndentLevel++;
            WriteType(type, w);
            w.IndentLevel--;
            w.WriteLine("}");
        }
        public void WriteType(TypeInfo type, IndentedWriter w)
        {

            w.WriteLine("public static class {0}{1}", type.TypeDef.Name, "Bindings");
            w.WriteLine("{");
            w.IndentLevel++;
            foreach(var field in type.Fields)
            {
                WriteAccessor(field, w);
            }
            w.IndentLevel--;
            w.WriteLine("}");
        }

        public void WriteAccessor(FieldInfo field, IndentedWriter w)
        {
            var fieldRefName = $"{field.FieldName}Ref";
            w.WriteLine("private static AccessTools.FieldRef<{0}, {1}> {2};", 
                field.ContainingType.ClassType, field.FieldType, fieldRefName);

            var getterName = $"Get{field.FieldName.FirstCharToUpper()}";
            w.WriteLine("public static {0} {1}(this {2} instance)", 
                field.FieldType, getterName, field.ContainingType.ClassType);
            w.WriteLine("{");
            w.IndentLevel++;
            w.WriteLine("if({0} == null) {0} = AccessTools.FieldRefAccess<{1}, {2}>(\"{3}\");",
                fieldRefName, field.ContainingType.ClassType, field.FieldType, field.FieldName);
            w.WriteLine("return {0}(instance);", fieldRefName);
            w.IndentLevel--;
            w.WriteLine("}");

            var setterName = $"Set{field.FieldName.FirstCharToUpper()}";
            w.WriteLine("public static void {0}(this {1} instance, {2} value)",
                setterName, field.ContainingType.ClassType, field.FieldType);
            w.WriteLine("{");
            w.IndentLevel++;
            w.WriteLine("if({0} == null) {0} = AccessTools.FieldRefAccess<{1}, {2}>(\"{3}\");",
                fieldRefName, field.ContainingType.ClassType, field.FieldType, field.FieldName);
            w.WriteLine("{0}(instance) = value;", fieldRefName);
            w.IndentLevel--;
            w.WriteLine("}");
        }
    }
}
