using ICSharpCode.Decompiler.TypeSystem;
using System.Collections.Generic;

namespace ReflectionBindingGenerator
{
    public static class IlSpyUtil
    {
        public static ITypeDefinition GetConcreteType(IType type)
        {
            if (type is ArrayType arrType)
            {
                return GetConcreteType(arrType.ElementType);
            }
            var typedef = type.GetDefinition();
            if (typedef == null) throw new System.Exception("Could not find concrete type");
            return typedef;
        }

        public static IEnumerable<ITypeDefinition> IterateType(IType type)
        {
            if (type is ArrayType arrType)
            {
                foreach (var t in IterateType(arrType.ElementType))
                {
                    yield return t;
                }
                yield break;
            }
            var typedef = type.GetDefinition();
            if (typedef == null) throw new System.Exception("Could not find concrete type");
            yield return typedef;
            foreach (var p in type.TypeArguments)
            {
                foreach (var t in IterateType(p))
                {
                    yield return t;
                }
            }
        }
    }
}
