using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionMagicAffinityExtensions
    {
        public static T SetAdditionalScribedSpells<T>(this T definition, int value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("additionalScribedSpells", value);
            return definition;
        }

        public static T SetCanFailSpellcasting<T>(this T definition, bool value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("canFailSpellcasting", value);
            return definition;
        }

        public static T SetCanUseProficientWeaponAsFocus<T>(this T definition, bool value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("canUseProficientWeaponAsFocus", value);
            return definition;
        }

        public static T SetConcentrationAdvantage<T>(this T definition, AdvantageType value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("concentrationAdvantage", value);
            return definition;
        }

        public static T SetDeviceTagsAutoIdentifying<T>(this T definition, List<string> value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("deviceTagsAutoIdentifying", value);
            return definition;
        }

        public static T SetExtendedSpellList<T>(this T definition, SpellListDefinition value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("extendedSpellList", value);
            return definition;
        }

        public static T SetForcedSavingThrowAffinity<T>(this T definition, AdvantageType value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("forcedSavingThrowAffinity", value);
            return definition;
        }

        public static T SetForcedSpellDefinition<T>(this T definition, SpellDefinition value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("forcedSpellDefinition", value);
            return definition;
        }

        public static T SetForceHalfDamageOnCantrips<T>(this T definition, bool value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("forceHalfDamageOnCantrips", value);
            return definition;
        }

        public static T SetImpairedSpeech<T>(this T definition, bool value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("impairedSpeech", value);
            return definition;
        }

        public static T SetMaxPreparedSpellsModifier<T>(this T definition, int value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("maxPreparedSpellsModifier", value);
            return definition;
        }

        public static T SetOverConcentrationThreshold<T>(this T definition, int value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("overConcentrationThreshold", value);
            return definition;
        }

        public static T SetRangeSpellNoProximityPenalty<T>(this T definition, bool value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("rangeSpellNoProximityPenalty", value);
            return definition;
        }

        public static T SetRitualCasting<T>(this T definition, RitualCasting value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("ritualCasting", value);
            return definition;
        }

        public static T SetSaveDCModifier<T>(this T definition, int value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("saveDCModifier", value);
            return definition;
        }

        public static T SetScribeAdvantageType<T>(this T definition, AdvantageType value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("scribeAdvantageType", value);
            return definition;
        }

        public static T SetScribeCostMultiplier<T>(this T definition, float value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("scribeCostMultiplier", value);
            return definition;
        }

        public static T SetScribeDurationMultiplier<T>(this T definition, float value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("scribeDurationMultiplier", value);
            return definition;
        }

        public static T SetSomaticWithWeapon<T>(this T definition, bool value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("somaticWithWeapon", value);
            return definition;
        }

        public static T SetSomaticWithWeaponOrShield<T>(this T definition, bool value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("somaticWithWeaponOrShield", value);
            return definition;
        }

        public static T SetSpellAttackModifier<T>(this T definition, int value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("spellAttackModifier", value);
            return definition;
        }

        public static T SetSpellcastingSuccessDC<T>(this T definition, int value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("spellcastingSuccessDC", value);
            return definition;
        }

        public static T SetSpellImmunities<T>(this T definition, List<string> value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("spellImmunities", value);
            return definition;
        }

        public static T SetUsesWarList<T>(this T definition, bool value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("usesWarList", value);
            return definition;
        }

        public static T SetWarListSlotBonus<T>(this T definition, int value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("warListSlotBonus", value);
            return definition;
        }

        public static T SetWarListSpells<T>(this T definition, List<string> value)
            where T : FeatureDefinitionMagicAffinity
        {
            definition.SetField("warListSpells", value);
            return definition;
        }
    }
}