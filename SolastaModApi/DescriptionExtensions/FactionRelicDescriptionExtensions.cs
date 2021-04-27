using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FactionRelicDescriptionExtensions
    {
        public static T SetLoreValue<T>(this T entity, int value)
            where T : FactionRelicDescription
        {
            entity.SetField("loreValue", value);
            return entity;
        }

        public static T SetRedeemCosts<T>(this T entity, int[] value)
            where T : FactionRelicDescription
        {
            entity.SetField("redeemCosts", value);
            return entity;
        }
    }
}