using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionMagicAffinityExtensions
    {
        public static T SetAdditionalScribedSpells<T>(this T entity, int value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("additionalScribedSpells", value);
            return entity;
        }

        public static T SetCanFailSpellcasting<T>(this T entity, bool value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("canFailSpellcasting", value);
            return entity;
        }

        public static T SetCanUseProficientWeaponAsFocus<T>(this T entity, bool value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("canUseProficientWeaponAsFocus", value);
            return entity;
        }

        public static T SetConcentrationAdvantage<T>(this T entity, AdvantageType value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("concentrationAdvantage", value);
            return entity;
        }

        public static T SetExtendedSpellList<T>(this T entity, SpellListDefinition value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("extendedSpellList", value);
            return entity;
        }

        public static T SetForcedSavingThrowAffinity<T>(this T entity, AdvantageType value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("forcedSavingThrowAffinity", value);
            return entity;
        }

        public static T SetForcedSpellDefinition<T>(this T entity, SpellDefinition value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("forcedSpellDefinition", value);
            return entity;
        }

        public static T SetForceHalfDamageOnCantrips<T>(this T entity, bool value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("forceHalfDamageOnCantrips", value);
            return entity;
        }

        public static T SetImpairedSpeech<T>(this T entity, bool value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("impairedSpeech", value);
            return entity;
        }

        public static T SetMaxPreparedSpellsModifier<T>(this T entity, int value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("maxPreparedSpellsModifier", value);
            return entity;
        }

        public static T SetOverConcentrationThreshold<T>(this T entity, int value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("overConcentrationThreshold", value);
            return entity;
        }

        public static T SetRangeSpellNoProximityPenalty<T>(this T entity, bool value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("rangeSpellNoProximityPenalty", value);
            return entity;
        }

        public static T SetRitualCasting<T>(this T entity, RitualCasting value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("ritualCasting", value);
            return entity;
        }

        public static T SetSaveDCModifier<T>(this T entity, int value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("saveDCModifier", value);
            return entity;
        }

        public static T SetScribeAdvantageType<T>(this T entity, AdvantageType value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("scribeAdvantageType", value);
            return entity;
        }

        public static T SetScribeCostMultiplier<T>(this T entity, float value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("scribeCostMultiplier", value);
            return entity;
        }

        public static T SetScribeDurationMultiplier<T>(this T entity, float value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("scribeDurationMultiplier", value);
            return entity;
        }

        public static T SetSomaticWithWeapon<T>(this T entity, bool value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("somaticWithWeapon", value);
            return entity;
        }

        public static T SetSomaticWithWeaponOrShield<T>(this T entity, bool value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("somaticWithWeaponOrShield", value);
            return entity;
        }

        public static T SetSpellAttackModifier<T>(this T entity, int value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("spellAttackModifier", value);
            return entity;
        }

        public static T SetSpellcastingSuccessDC<T>(this T entity, int value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("spellcastingSuccessDC", value);
            return entity;
        }

        public static T SetUsesWarList<T>(this T entity, bool value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("usesWarList", value);
            return entity;
        }

        public static T SetWarListSlotBonus<T>(this T entity, int value)
            where T : FeatureDefinitionMagicAffinity
        {
            entity.SetField("warListSlotBonus", value);
            return entity;
        }
    }
}