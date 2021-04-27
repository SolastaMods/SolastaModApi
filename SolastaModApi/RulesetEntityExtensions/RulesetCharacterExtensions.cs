using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class RulesetCharacterExtensions
    {
        public static T SetBaseFaction<T>(this T entity, FactionDefinition value)
            where T : RulesetCharacter
        {
            entity.SetField("baseFaction", value);
            return entity;
        }

        public static T SetCarryingSize<T>(this T entity, CreatureSize value)
            where T : RulesetCharacter
        {
            entity.SetField("carryingSize", value);
            return entity;
        }

        public static T SetConcentratedSpell<T>(this T entity, RulesetEffectSpell value)
            where T : RulesetCharacter
        {
            entity.SetField("concentratedSpell", value);
            return entity;
        }

        public static T SetControlledEffectProxy<T>(this T entity, RulesetCharacterEffectProxy value)
            where T : RulesetCharacter
        {
            entity.SetField("controlledEffectProxy", value);
            return entity;
        }

        public static T SetFactionOverride<T>(this T entity, FactionDefinition value)
            where T : RulesetCharacter
        {
            entity.SetField("factionOverride", value);
            return entity;
        }

        public static T SetMaxJumpType<T>(this T entity, RulesetCharacter.JumpRuleType value)
            where T : RulesetCharacter
        {
            entity.SetField("maxJumpType", value);
            return entity;
        }

        public static T SetMotionRangeFlags<T>(this T entity, RulesetCharacter.MotionRange value)
            where T : RulesetCharacter
        {
            entity.SetField("motionRangeFlags", value);
            return entity;
        }

        public static T SetVisionHeight<T>(this T entity, float value)
            where T : RulesetCharacter
        {
            entity.SetField("visionHeight", value);
            return entity;
        }

        public static T SetVisionHeightFactor<T>(this T entity, float value)
            where T : RulesetCharacter
        {
            entity.SetField("visionHeightFactor", value);
            return entity;
        }

        public static T SetWieldingSize<T>(this T entity, CreatureSize value)
            where T : RulesetCharacter
        {
            entity.SetField("wieldingSize", value);
            return entity;
        }
    }
}