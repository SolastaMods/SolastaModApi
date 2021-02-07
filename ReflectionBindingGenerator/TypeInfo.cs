using ICSharpCode.Decompiler.TypeSystem;
using System.Collections.Generic;

namespace ReflectionBindingGenerator
{
    public class TypeInfo
    {
        public ITypeDefinition TypeDef;
        public string ClassType;
        public string Name;
        public string Filepath;
        public HashSet<string> UsingStatements = new HashSet<string>()
        {
            "using HarmonyLib;"
        };
        public List<FieldInfo> Fields = new List<FieldInfo>();
    }
}
