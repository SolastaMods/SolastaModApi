using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionMoveThroughEnemyModifierExtensions
    {
        public static FeatureDefinitionMoveThroughEnemyModifier SetMinSizeDifference(this FeatureDefinitionMoveThroughEnemyModifier definition, int value)
        {
            definition.SetField("minSizeDifference", value);
            return definition;
        }
    }
}