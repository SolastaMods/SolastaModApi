using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class MerchantDefinitionExtensions
    {
        public static T SetBuyBackPercent<T>(this T definition, int value)
            where T : MerchantDefinition
        {
            definition.SetField("buyBackPercent", value);
            return definition;
        }

        public static T SetCanDetectMagic<T>(this T definition, bool value)
            where T : MerchantDefinition
        {
            definition.SetField("canDetectMagic", value);
            return definition;
        }

        public static T SetCanIdentify<T>(this T definition, bool value)
            where T : MerchantDefinition
        {
            definition.SetField("canIdentify", value);
            return definition;
        }

        public static T SetDetectMagicCostGp<T>(this T definition, int value)
            where T : MerchantDefinition
        {
            definition.SetField("detectMagicCostGp", value);
            return definition;
        }

        public static T SetExposeFaction<T>(this T definition, bool value)
            where T : MerchantDefinition
        {
            definition.SetField("exposeFaction", value);
            return definition;
        }

        public static T SetFactionAffinity<T>(this T definition, string value)
            where T : MerchantDefinition
        {
            definition.SetField("factionAffinity", value);
            return definition;
        }

        public static T SetIdentifyCostGp<T>(this T definition, int value)
            where T : MerchantDefinition
        {
            definition.SetField("identifyCostGp", value);
            return definition;
        }

        public static T SetOverchargePercent<T>(this T definition, int value)
            where T : MerchantDefinition
        {
            definition.SetField("overchargePercent", value);
            return definition;
        }
    }
}