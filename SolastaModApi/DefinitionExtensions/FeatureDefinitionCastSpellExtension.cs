using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionCastSpellExtensions
    {
        public static void SetKnownCantrips(this FeatureDefinitionCastSpell definition, List<Int32> value)
        {
            definition.SetField("knownCantrips", value);
        }

        public static void SetKnownSpells(this FeatureDefinitionCastSpell definition, List<Int32> value)
        {
            definition.SetField("knownSpells", value);
        }

        public static void SetRestrictedSchools(this FeatureDefinitionCastSpell definition, List<String> value)
        {
            definition.SetField("restrictedSchools", value);
        }

        public static void SetScribedSpells(this FeatureDefinitionCastSpell definition, List<Int32> value)
        {
            definition.SetField("scribedSpells", value);
        }

        public static void SetSlotsPerLevels(this FeatureDefinitionCastSpell definition, List<FeatureDefinitionCastSpell.SlotsByLevelDuplet> value)
        {
            definition.SetField("slotsPerLevels", value);
        }

        public static void SetSlotsRecharge(this FeatureDefinitionCastSpell definition, RechargeRate value)
        {
            definition.SetField("slotsRecharge", value);
        }

        public static void SetSpellcastingAbility(this FeatureDefinitionCastSpell definition, String value)
        {
            definition.SetField("spellcastingAbility", value);
        }

        public static void SetSpellCastingLevel(this FeatureDefinitionCastSpell definition, Int32 value)
        {
            definition.SetField("spellCastingLevel", value);
        }

        public static void SetSpellCastingOrigin(this FeatureDefinitionCastSpell definition, FeatureDefinitionCastSpell.CastingOrigin value)
        {
            definition.SetField("spellCastingOrigin", value);
        }

        public static void SetSpellcastingParametersComputation(this FeatureDefinitionCastSpell definition, SpellcastingParametersComputation value)
        {
            definition.SetField("spellcastingParametersComputation", value);
        }

        public static void SetSpellKnowledge(this FeatureDefinitionCastSpell definition, SpellKnowledge value)
        {
            definition.SetField("spellKnowledge", value);
        }

        public static void SetSpellListDefinition(this FeatureDefinitionCastSpell definition, SpellListDefinition value)
        {
            definition.SetField("spellListDefinition", value);
        }

        public static void SetSpellPreparationCount(this FeatureDefinitionCastSpell definition, SpellPreparationCount value)
        {
            definition.SetField("spellPreparationCount", value);
        }

        public static void SetSpellReadyness(this FeatureDefinitionCastSpell definition, SpellReadyness value)
        {
            definition.SetField("spellReadyness", value);
        }

        public static void SetStaticDCValue(this FeatureDefinitionCastSpell definition, Int32 value)
        {
            definition.SetField("staticDCValue", value);
        }

        public static void SetStaticToHitValue(this FeatureDefinitionCastSpell definition, Int32 value)
        {
            definition.SetField("staticToHitValue", value);
        }
    }
}