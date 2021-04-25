using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FactionStatusDefinitionExtensions
    {
        public static FactionStatusDefinition SetCeiling(this FactionStatusDefinition definition, int value)
        {
            definition.SetField("ceiling", value);
            return definition;
        }

        public static FactionStatusDefinition SetCombatSide(this FactionStatusDefinition definition, Side value)
        {
            definition.SetField("combatSide", value);
            return definition;
        }

        public static FactionStatusDefinition SetExplorationSide(this FactionStatusDefinition definition, Side value)
        {
            definition.SetField("explorationSide", value);
            return definition;
        }

        public static FactionStatusDefinition SetMerchantRebatePercent(this FactionStatusDefinition definition, int value)
        {
            definition.SetField("merchantRebatePercent", value);
            return definition;
        }
    }
}