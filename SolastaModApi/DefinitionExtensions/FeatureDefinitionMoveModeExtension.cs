using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionMoveModeExtensions
    {
        public static FeatureDefinitionMoveMode SetMoveMode(this FeatureDefinitionMoveMode definition, MoveMode value)
        {
            definition.SetField("moveMode", value);
            return definition;
        }

        public static FeatureDefinitionMoveMode SetSpeed(this FeatureDefinitionMoveMode definition, int value)
        {
            definition.SetField("speed", value);
            return definition;
        }
    }
}