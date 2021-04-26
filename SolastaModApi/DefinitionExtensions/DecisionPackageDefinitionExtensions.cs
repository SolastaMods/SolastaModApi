using SolastaModApi.Infrastructure;
using TA.AI;

namespace SolastaModApi
{
    public static class DecisionPackageDefinitionExtensions
    {
        public static T SetPackage<T>(this T definition, DecisionPackageDescription value)
            where T : DecisionPackageDefinition
        {
            definition.SetField("package", value);
            return definition;
        }
    }
}