using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionMoveModeExtensions
    {
        public static T SetMoveMode<T>(this T definition, MoveMode value)
            where T : FeatureDefinitionMoveMode
        {
            definition.SetField("moveMode", value);
            return definition;
        }

        public static T SetSpeed<T>(this T definition, int value)
            where T : FeatureDefinitionMoveMode
        {
            definition.SetField("speed", value);
            return definition;
        }
    }
}