using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionMagicAffinityExtensions
    {
        public static void SetAdditionalScribedSpells(this FeatureDefinitionMagicAffinity definition, Int32 value)
        {
            definition.SetField("additionalScribedSpells", value);
        }

        public static void SetCanFailSpellcasting(this FeatureDefinitionMagicAffinity definition, Boolean value)
        {
            definition.SetField("canFailSpellcasting", value);
        }

        public static void SetCanUseProficientWeaponAsFocus(this FeatureDefinitionMagicAffinity definition, Boolean value)
        {
            definition.SetField("canUseProficientWeaponAsFocus", value);
        }

        public static void SetConcentrationAdvantage(this FeatureDefinitionMagicAffinity definition, AdvantageType value)
        {
            definition.SetField("concentrationAdvantage", value);
        }

        public static void SetDeviceTagsAutoIdentifying(this FeatureDefinitionMagicAffinity definition, List<String> value)
        {
            definition.SetField("deviceTagsAutoIdentifying", value);
        }

        public static void SetExtendedSpellList(this FeatureDefinitionMagicAffinity definition, SpellListDefinition value)
        {
            definition.SetField("extendedSpellList", value);
        }

        public static void SetForcedSavingThrowAffinity(this FeatureDefinitionMagicAffinity definition, AdvantageType value)
        {
            definition.SetField("forcedSavingThrowAffinity", value);
        }

        public static void SetForcedSpellDefinition(this FeatureDefinitionMagicAffinity definition, SpellDefinition value)
        {
            definition.SetField("forcedSpellDefinition", value);
        }

        public static void SetForceHalfDamageOnCantrips(this FeatureDefinitionMagicAffinity definition, Boolean value)
        {
            definition.SetField("forceHalfDamageOnCantrips", value);
        }

        public static void SetImpairedSpeech(this FeatureDefinitionMagicAffinity definition, Boolean value)
        {
            definition.SetField("impairedSpeech", value);
        }

        public static void SetMaxPreparedSpellsModifier(this FeatureDefinitionMagicAffinity definition, Int32 value)
        {
            definition.SetField("maxPreparedSpellsModifier", value);
        }

        public static void SetOverConcentrationThreshold(this FeatureDefinitionMagicAffinity definition, Int32 value)
        {
            definition.SetField("overConcentrationThreshold", value);
        }

        public static void SetRangeSpellNoProximityPenalty(this FeatureDefinitionMagicAffinity definition, Boolean value)
        {
            definition.SetField("rangeSpellNoProximityPenalty", value);
        }

        public static void SetRitualCasting(this FeatureDefinitionMagicAffinity definition, RitualCasting value)
        {
            definition.SetField("ritualCasting", value);
        }

        public static void SetSaveDCModifier(this FeatureDefinitionMagicAffinity definition, Int32 value)
        {
            definition.SetField("saveDCModifier", value);
        }

        public static void SetScribeAdvantageType(this FeatureDefinitionMagicAffinity definition, AdvantageType value)
        {
            definition.SetField("scribeAdvantageType", value);
        }

        public static void SetScribeCostMultiplier(this FeatureDefinitionMagicAffinity definition, Single value)
        {
            definition.SetField("scribeCostMultiplier", value);
        }

        public static void SetScribeDurationMultiplier(this FeatureDefinitionMagicAffinity definition, Single value)
        {
            definition.SetField("scribeDurationMultiplier", value);
        }

        public static void SetSomaticWithWeapon(this FeatureDefinitionMagicAffinity definition, Boolean value)
        {
            definition.SetField("somaticWithWeapon", value);
        }

        public static void SetSomaticWithWeaponOrShield(this FeatureDefinitionMagicAffinity definition, Boolean value)
        {
            definition.SetField("somaticWithWeaponOrShield", value);
        }

        public static void SetSpellAttackModifier(this FeatureDefinitionMagicAffinity definition, Int32 value)
        {
            definition.SetField("spellAttackModifier", value);
        }

        public static void SetSpellcastingSuccessDC(this FeatureDefinitionMagicAffinity definition, Int32 value)
        {
            definition.SetField("spellcastingSuccessDC", value);
        }

        public static void SetSpellImmunities(this FeatureDefinitionMagicAffinity definition, List<String> value)
        {
            definition.SetField("spellImmunities", value);
        }

        public static void SetUsesWarList(this FeatureDefinitionMagicAffinity definition, Boolean value)
        {
            definition.SetField("usesWarList", value);
        }

        public static void SetWarListSlotBonus(this FeatureDefinitionMagicAffinity definition, Int32 value)
        {
            definition.SetField("warListSlotBonus", value);
        }

        public static void SetWarListSpells(this FeatureDefinitionMagicAffinity definition, List<String> value)
        {
            definition.SetField("warListSpells", value);
        }
    }
}