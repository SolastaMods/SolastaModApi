using SolastaModApi.Infrastructure;
using TA.AI;

namespace SolastaModApi
{
    public static class DecisionPackageDefinitionExtensions
    {
        public static T SetPackage<T>(this T entity, DecisionPackageDescription value)
            where T : DecisionPackageDefinition
        {
            entity.SetField("package", value);
            return entity;
        }
    }
}