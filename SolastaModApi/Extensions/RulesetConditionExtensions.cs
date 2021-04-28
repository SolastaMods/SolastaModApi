using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class RulesetConditionExtensions
    {
        public static T SetDurationType<T>(this T entity, DurationType value)
            where T : RulesetCondition
        {
            entity.SetField("durationType", value);
            return entity;
        }
    }
}