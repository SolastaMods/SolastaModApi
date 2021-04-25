using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionMoveThroughEnemyModifierExtensions
    {
        public static void SetMinSizeDifference(this FeatureDefinitionMoveThroughEnemyModifier definition, Int32 value)
        {
            definition.SetField("minSizeDifference", value);
        }
    }
}