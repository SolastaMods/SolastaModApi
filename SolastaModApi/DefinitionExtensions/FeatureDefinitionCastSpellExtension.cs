using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionCastSpellExtensions
    {
        public static FeatureDefinitionCastSpell SetKnownCantrips(this FeatureDefinitionCastSpell definition, List<int> value)
        {
            definition.SetField("knownCantrips", value);
            return definition;
        }

        public static FeatureDefinitionCastSpell SetKnownSpells(this FeatureDefinitionCastSpell definition, List<int> value)
        {
            definition.SetField("knownSpells", value);
            return definition;
        }

        public static FeatureDefinitionCastSpell SetRestrictedSchools(this FeatureDefinitionCastSpell definition, List<string> value)
        {
            definition.SetField("restrictedSchools", value);
            return definition;
        }

        public static FeatureDefinitionCastSpell SetScribedSpells(this FeatureDefinitionCastSpell definition, List<int> value)
        {
            definition.SetField("scribedSpells", value);
            return definition;
        }

        public static FeatureDefinitionCastSpell SetSlotsPerLevels(this FeatureDefinitionCastSpell definition, List<FeatureDefinitionCastSpell.SlotsByLevelDuplet> value)
        {
            definition.SetField("slotsPerLevels", value);
            return definition;
        }

        public static FeatureDefinitionCastSpell SetSlotsRecharge(this FeatureDefinitionCastSpell definition, RechargeRate value)
        {
            definition.SetField("slotsRecharge", value);
            return definition;
        }

        public static FeatureDefinitionCastSpell SetSpellcastingAbility(this FeatureDefinitionCastSpell definition, string value)
        {
            definition.SetField("spellcastingAbility", value);
            return definition;
        }

        public static FeatureDefinitionCastSpell SetSpellCastingLevel(this FeatureDefinitionCastSpell definition, int value)
        {
            definition.SetField("spellCastingLevel", value);
            return definition;
        }

        public static FeatureDefinitionCastSpell SetSpellCastingOrigin(this FeatureDefinitionCastSpell definition, FeatureDefinitionCastSpell.CastingOrigin value)
        {
            definition.SetField("spellCastingOrigin", value);
            return definition;
        }

        public static FeatureDefinitionCastSpell SetSpellcastingParametersComputation(this FeatureDefinitionCastSpell definition, SpellcastingParametersComputation value)
        {
            definition.SetField("spellcastingParametersComputation", value);
            return definition;
        }

        public static FeatureDefinitionCastSpell SetSpellKnowledge(this FeatureDefinitionCastSpell definition, SpellKnowledge value)
        {
            definition.SetField("spellKnowledge", value);
            return definition;
        }

        public static FeatureDefinitionCastSpell SetSpellListDefinition(this FeatureDefinitionCastSpell definition, SpellListDefinition value)
        {
            definition.SetField("spellListDefinition", value);
            return definition;
        }

        public static FeatureDefinitionCastSpell SetSpellPreparationCount(this FeatureDefinitionCastSpell definition, SpellPreparationCount value)
        {
            definition.SetField("spellPreparationCount", value);
            return definition;
        }

        public static FeatureDefinitionCastSpell SetSpellReadyness(this FeatureDefinitionCastSpell definition, SpellReadyness value)
        {
            definition.SetField("spellReadyness", value);
            return definition;
        }

        public static FeatureDefinitionCastSpell SetStaticDCValue(this FeatureDefinitionCastSpell definition, int value)
        {
            definition.SetField("staticDCValue", value);
            return definition;
        }

        public static FeatureDefinitionCastSpell SetStaticToHitValue(this FeatureDefinitionCastSpell definition, int value)
        {
            definition.SetField("staticToHitValue", value);
            return definition;
        }
    }
}