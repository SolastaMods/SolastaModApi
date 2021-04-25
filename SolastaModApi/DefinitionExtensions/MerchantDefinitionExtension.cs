using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MerchantDefinitionExtensions
    {
        public static void SetBuyBackPercent(this MerchantDefinition definition, Int32 value)
        {
            definition.SetField("buyBackPercent", value);
        }

        public static void SetCanDetectMagic(this MerchantDefinition definition, Boolean value)
        {
            definition.SetField("canDetectMagic", value);
        }

        public static void SetCanIdentify(this MerchantDefinition definition, Boolean value)
        {
            definition.SetField("canIdentify", value);
        }

        public static void SetDetectMagicCostGp(this MerchantDefinition definition, Int32 value)
        {
            definition.SetField("detectMagicCostGp", value);
        }

        public static void SetExposeFaction(this MerchantDefinition definition, Boolean value)
        {
            definition.SetField("exposeFaction", value);
        }

        public static void SetFactionAffinity(this MerchantDefinition definition, String value)
        {
            definition.SetField("factionAffinity", value);
        }

        public static void SetIdentifyCostGp(this MerchantDefinition definition, Int32 value)
        {
            definition.SetField("identifyCostGp", value);
        }

        public static void SetOverchargePercent(this MerchantDefinition definition, Int32 value)
        {
            definition.SetField("overchargePercent", value);
        }

        public static void SetStockUnitDescriptions(this MerchantDefinition definition, List<StockUnitDescription> value)
        {
            definition.SetField("stockUnitDescriptions", value);
        }
    }
}