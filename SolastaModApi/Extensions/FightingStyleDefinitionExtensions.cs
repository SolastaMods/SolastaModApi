using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FightingStyleDefinitionExtensions
    {
        public static T SetCondition<T>(this T entity, FightingStyleDefinition.TriggerCondition value)
            where T : FightingStyleDefinition
        {
            entity.SetField("condition", value);
            return entity;
        }
    }
}