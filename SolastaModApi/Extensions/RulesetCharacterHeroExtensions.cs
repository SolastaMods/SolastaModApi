using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class RulesetCharacterHeroExtensions
    {
        public static T SetTreasury<T>(this T entity, RulesetTreasury value)
            where T : RulesetCharacterHero
        {
            entity.SetField("treasury", value);
            return entity;
        }
    }
}