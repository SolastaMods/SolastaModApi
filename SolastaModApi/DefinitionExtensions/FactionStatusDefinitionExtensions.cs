using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FactionStatusDefinitionExtensions
    {
        public static T SetCeiling<T>(this T definition, int value)
            where T : FactionStatusDefinition
        {
            definition.SetField("ceiling", value);
            return definition;
        }

        public static T SetCombatSide<T>(this T definition, Side value)
            where T : FactionStatusDefinition
        {
            definition.SetField("combatSide", value);
            return definition;
        }

        public static T SetExplorationSide<T>(this T definition, Side value)
            where T : FactionStatusDefinition
        {
            definition.SetField("explorationSide", value);
            return definition;
        }

        public static T SetMerchantRebatePercent<T>(this T definition, int value)
            where T : FactionStatusDefinition
        {
            definition.SetField("merchantRebatePercent", value);
            return definition;
        }
    }
}