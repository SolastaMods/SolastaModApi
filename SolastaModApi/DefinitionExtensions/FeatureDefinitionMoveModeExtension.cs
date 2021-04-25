using SolastaModApi.Infrastructure;
using System;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionMoveModeExtensions
    {
        public static void SetMoveMode(this FeatureDefinitionMoveMode definition, MoveMode value)
        {
            definition.SetField("moveMode", value);
        }

        public static void SetSpeed(this FeatureDefinitionMoveMode definition, Int32 value)
        {
            definition.SetField("speed", value);
        }
    }
}