using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionMagicAffinityExtensions
    {
        public static FeatureDefinitionMagicAffinity SetAdditionalScribedSpells(this FeatureDefinitionMagicAffinity definition, int value)
        {
            definition.SetField("additionalScribedSpells", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetCanFailSpellcasting(this FeatureDefinitionMagicAffinity definition, bool value)
        {
            definition.SetField("canFailSpellcasting", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetCanUseProficientWeaponAsFocus(this FeatureDefinitionMagicAffinity definition, bool value)
        {
            definition.SetField("canUseProficientWeaponAsFocus", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetConcentrationAdvantage(this FeatureDefinitionMagicAffinity definition, AdvantageType value)
        {
            definition.SetField("concentrationAdvantage", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetDeviceTagsAutoIdentifying(this FeatureDefinitionMagicAffinity definition, List<string> value)
        {
            definition.SetField("deviceTagsAutoIdentifying", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetExtendedSpellList(this FeatureDefinitionMagicAffinity definition, SpellListDefinition value)
        {
            definition.SetField("extendedSpellList", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetForcedSavingThrowAffinity(this FeatureDefinitionMagicAffinity definition, AdvantageType value)
        {
            definition.SetField("forcedSavingThrowAffinity", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetForcedSpellDefinition(this FeatureDefinitionMagicAffinity definition, SpellDefinition value)
        {
            definition.SetField("forcedSpellDefinition", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetForceHalfDamageOnCantrips(this FeatureDefinitionMagicAffinity definition, bool value)
        {
            definition.SetField("forceHalfDamageOnCantrips", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetImpairedSpeech(this FeatureDefinitionMagicAffinity definition, bool value)
        {
            definition.SetField("impairedSpeech", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetMaxPreparedSpellsModifier(this FeatureDefinitionMagicAffinity definition, int value)
        {
            definition.SetField("maxPreparedSpellsModifier", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetOverConcentrationThreshold(this FeatureDefinitionMagicAffinity definition, int value)
        {
            definition.SetField("overConcentrationThreshold", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetRangeSpellNoProximityPenalty(this FeatureDefinitionMagicAffinity definition, bool value)
        {
            definition.SetField("rangeSpellNoProximityPenalty", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetRitualCasting(this FeatureDefinitionMagicAffinity definition, RitualCasting value)
        {
            definition.SetField("ritualCasting", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetSaveDCModifier(this FeatureDefinitionMagicAffinity definition, int value)
        {
            definition.SetField("saveDCModifier", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetScribeAdvantageType(this FeatureDefinitionMagicAffinity definition, AdvantageType value)
        {
            definition.SetField("scribeAdvantageType", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetScribeCostMultiplier(this FeatureDefinitionMagicAffinity definition, float value)
        {
            definition.SetField("scribeCostMultiplier", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetScribeDurationMultiplier(this FeatureDefinitionMagicAffinity definition, float value)
        {
            definition.SetField("scribeDurationMultiplier", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetSomaticWithWeapon(this FeatureDefinitionMagicAffinity definition, bool value)
        {
            definition.SetField("somaticWithWeapon", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetSomaticWithWeaponOrShield(this FeatureDefinitionMagicAffinity definition, bool value)
        {
            definition.SetField("somaticWithWeaponOrShield", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetSpellAttackModifier(this FeatureDefinitionMagicAffinity definition, int value)
        {
            definition.SetField("spellAttackModifier", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetSpellcastingSuccessDC(this FeatureDefinitionMagicAffinity definition, int value)
        {
            definition.SetField("spellcastingSuccessDC", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetSpellImmunities(this FeatureDefinitionMagicAffinity definition, List<string> value)
        {
            definition.SetField("spellImmunities", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetUsesWarList(this FeatureDefinitionMagicAffinity definition, bool value)
        {
            definition.SetField("usesWarList", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetWarListSlotBonus(this FeatureDefinitionMagicAffinity definition, int value)
        {
            definition.SetField("warListSlotBonus", value);
            return definition;
        }

        public static FeatureDefinitionMagicAffinity SetWarListSpells(this FeatureDefinitionMagicAffinity definition, List<string> value)
        {
            definition.SetField("warListSpells", value);
            return definition;
        }
    }
}