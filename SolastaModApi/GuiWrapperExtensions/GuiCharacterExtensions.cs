using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
    public static class GuiCharacterExtensions
    {
        public static T SetGameCampaignCharacter<T>(this T entity, GameCampaignCharacter value)
            where T : GuiCharacter
        {
            entity.SetField("gameCampaignCharacter", value);
            return entity;
        }

        public static T SetGameLocationCharacter<T>(this T entity, GameLocationCharacter value)
            where T : GuiCharacter
        {
            entity.SetField("gameLocationCharacter", value);
            return entity;
        }

        public static T SetListing<T>(this T entity, string value)
            where T : GuiCharacter
        {
            entity.SetField("listing", value);
            return entity;
        }

        public static T SetMonsterSpriteRef<T>(this T entity, Sprite value)
            where T : GuiCharacter
        {
            entity.SetField("monsterSpriteRef", value);
            return entity;
        }

        public static T SetRulesetCharacter<T>(this T entity, RulesetCharacter value)
            where T : GuiCharacter
        {
            entity.SetField("rulesetCharacter", value);
            return entity;
        }

        public static T SetRulesetCharacterEffectProxy<T>(this T entity, RulesetCharacterEffectProxy value)
            where T : GuiCharacter
        {
            entity.SetField("rulesetCharacterEffectProxy", value);
            return entity;
        }

        public static T SetRulesetCharacterHero<T>(this T entity, RulesetCharacterHero value)
            where T : GuiCharacter
        {
            entity.SetField("rulesetCharacterHero", value);
            return entity;
        }

        public static T SetRulesetCharacterMonster<T>(this T entity, RulesetCharacterMonster value)
            where T : GuiCharacter
        {
            entity.SetField("rulesetCharacterMonster", value);
            return entity;
        }

        public static T SetSnapshot<T>(this T entity, RulesetCharacterHero.Snapshot value)
            where T : GuiCharacter
        {
            entity.SetField("snapshot", value);
            return entity;
        }
    }
}