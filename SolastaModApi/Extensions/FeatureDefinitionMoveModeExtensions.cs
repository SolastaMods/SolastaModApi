using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionMoveModeExtensions
    {
        public static T SetMoveMode<T>(this T entity, MoveMode value)
            where T : FeatureDefinitionMoveMode
        {
            entity.SetField("moveMode", value);
            return entity;
        }

        public static T SetSpeed<T>(this T entity, int value)
            where T : FeatureDefinitionMoveMode
        {
            entity.SetField("speed", value);
            return entity;
        }
    }
}