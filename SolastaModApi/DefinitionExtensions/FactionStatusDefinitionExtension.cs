using SolastaModApi.Infrastructure;
using System;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FactionStatusDefinitionExtensions
    {
        public static void SetCeiling(this FactionStatusDefinition definition, Int32 value)
        {
            definition.SetField("ceiling", value);
        }

        public static void SetCombatSide(this FactionStatusDefinition definition, Side value)
        {
            definition.SetField("combatSide", value);
        }

        public static void SetExplorationSide(this FactionStatusDefinition definition, Side value)
        {
            definition.SetField("explorationSide", value);
        }

        public static void SetMerchantRebatePercent(this FactionStatusDefinition definition, Int32 value)
        {
            definition.SetField("merchantRebatePercent", value);
        }
    }
}