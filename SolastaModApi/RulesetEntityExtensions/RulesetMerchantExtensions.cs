using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class RulesetMerchantExtensions
    {
        public static T SetMerchantDefinition<T>(this T entity, MerchantDefinition value)
            where T : RulesetMerchant
        {
            entity.SetField("merchantDefinition", value);
            return entity;
        }
    }
}