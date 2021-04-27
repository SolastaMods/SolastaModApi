using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class RulesetItemPropertyExtensions
    {
        public static T SetFeatureDefinition<T>(this T entity, FeatureDefinition value)
            where T : RulesetItemProperty
        {
            entity.SetField("featureDefinition", value);
            return entity;
        }

        public static T SetTargetItemGuid<T>(this T entity, ulong value)
            where T : RulesetItemProperty
        {
            entity.SetField("targetItemGuid", value);
            return entity;
        }

        public static T SetUsageLimitation<T>(this T entity, ItemPropertyUsage value)
            where T : RulesetItemProperty
        {
            entity.SetField("usageLimitation", value);
            return entity;
        }
    }
}