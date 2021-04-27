using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionPointPoolExtensions
    {
        public static T SetPoolAmount<T>(this T definition, int value)
            where T : FeatureDefinitionPointPool
        {
            definition.SetField("poolAmount", value);
            return definition;
        }

        public static T SetPoolType<T>(this T definition, HeroDefinitions.PointsPoolType value)
            where T : FeatureDefinitionPointPool
        {
            definition.SetField("poolType", value);
            return definition;
        }

        public static T SetUniqueChoices<T>(this T definition, bool value)
            where T : FeatureDefinitionPointPool
        {
            definition.SetField("uniqueChoices", value);
            return definition;
        }
    }
}