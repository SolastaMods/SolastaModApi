using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionMoveThroughEnemyModifierExtensions
    {
        public static T SetMinSizeDifference<T>(this T definition, int value)
            where T : FeatureDefinitionMoveThroughEnemyModifier
        {
            definition.SetField("minSizeDifference", value);
            return definition;
        }
    }
}