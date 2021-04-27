using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class GuiActiveConditionExtensions
    {
        public static T SetActiveCondition<T>(this T entity, RulesetCondition value)
            where T : GuiActiveCondition
        {
            entity.SetField("activeCondition", value);
            return entity;
        }

        public static T SetConditionDefinition<T>(this T entity, ConditionDefinition value)
            where T : GuiActiveCondition
        {
            entity.SetField("conditionDefinition", value);
            return entity;
        }
    }
}