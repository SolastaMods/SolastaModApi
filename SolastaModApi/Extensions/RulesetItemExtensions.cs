using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class RulesetItemExtensions
    {
        public static T SetGains<T>(this T entity, int[] value)
            where T : RulesetItem
        {
            entity.SetField("gains", value);
            return entity;
        }
    }
}