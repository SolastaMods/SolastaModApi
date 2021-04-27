using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class WealthPileDescriptionExtensions
    {
        public static T SetBonuses<T>(this T entity, int[] value)
            where T : WealthPileDescription
        {
            entity.SetField("bonuses", value);
            return entity;
        }

        public static T SetDiceTypes<T>(this T entity, DieType[] value)
            where T : WealthPileDescription
        {
            entity.SetField("diceTypes", value);
            return entity;
        }

        public static T SetWealth<T>(this T entity, int[] value)
            where T : WealthPileDescription
        {
            entity.SetField("wealth", value);
            return entity;
        }
    }
}