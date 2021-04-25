using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MerchantDefinitionExtensions
    {
        public static MerchantDefinition SetBuyBackPercent(this MerchantDefinition definition, int value)
        {
            definition.SetField("buyBackPercent", value);
            return definition;
        }

        public static MerchantDefinition SetCanDetectMagic(this MerchantDefinition definition, bool value)
        {
            definition.SetField("canDetectMagic", value);
            return definition;
        }

        public static MerchantDefinition SetCanIdentify(this MerchantDefinition definition, bool value)
        {
            definition.SetField("canIdentify", value);
            return definition;
        }

        public static MerchantDefinition SetDetectMagicCostGp(this MerchantDefinition definition, int value)
        {
            definition.SetField("detectMagicCostGp", value);
            return definition;
        }

        public static MerchantDefinition SetExposeFaction(this MerchantDefinition definition, bool value)
        {
            definition.SetField("exposeFaction", value);
            return definition;
        }

        public static MerchantDefinition SetFactionAffinity(this MerchantDefinition definition, string value)
        {
            definition.SetField("factionAffinity", value);
            return definition;
        }

        public static MerchantDefinition SetIdentifyCostGp(this MerchantDefinition definition, int value)
        {
            definition.SetField("identifyCostGp", value);
            return definition;
        }

        public static MerchantDefinition SetOverchargePercent(this MerchantDefinition definition, int value)
        {
            definition.SetField("overchargePercent", value);
            return definition;
        }

        public static MerchantDefinition SetStockUnitDescriptions(this MerchantDefinition definition, List<StockUnitDescription> value)
        {
            definition.SetField("stockUnitDescriptions", value);
            return definition;
        }
    }
}