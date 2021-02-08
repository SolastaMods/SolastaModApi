using System.IO;

namespace ReflectionBindingGenerator
{
    public class IlspyAssemblyResolver : ICSharpCode.Decompiler.Metadata.IAssemblyResolver
    {
        string ManagedDir;
        public IlspyAssemblyResolver(string managedDir)
        {
            ManagedDir = managedDir;
        }
        public void Dispose()
        {
        }

        public ICSharpCode.Decompiler.Metadata.PEFile Resolve(ICSharpCode.Decompiler.Metadata.IAssemblyReference reference)
        {
            var path = Path.Combine(ManagedDir, reference.Name + ".dll");
            if (File.Exists(path))
            {
                return new ICSharpCode.Decompiler.Metadata.PEFile(path);
            }
            return null;
        }

        public ICSharpCode.Decompiler.Metadata.PEFile ResolveModule(ICSharpCode.Decompiler.Metadata.PEFile mainModule, string moduleName)
        {
            var path = Path.Combine(ManagedDir, moduleName + ".dll");
            if (File.Exists(path))
            {
                return new ICSharpCode.Decompiler.Metadata.PEFile(path);
            }
            return null;
        }
    }
}
