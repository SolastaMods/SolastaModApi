using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class SpellDefinitionExtensions
    {
        public static SpellDefinition SetAiParameters(this SpellDefinition definition, SpellAIParameters value)
        {
            definition.SetField("aiParameters", value);
            return definition;
        }

        public static SpellDefinition SetCastingTime(this SpellDefinition definition, ActivationTime value)
        {
            definition.SetField("castingTime", value);
            return definition;
        }

        public static SpellDefinition SetConcentrationAction(this SpellDefinition definition, ActionParameter value)
        {
            definition.SetField("concentrationAction", value);
            return definition;
        }

        public static SpellDefinition SetEffectDescription(this SpellDefinition definition, EffectDescription value)
        {
            definition.SetField("effectDescription", value);
            return definition;
        }

        public static SpellDefinition SetImplemented(this SpellDefinition definition, bool value)
        {
            definition.SetField("implemented", value);
            return definition;
        }

        public static SpellDefinition SetMaterialComponentType(this SpellDefinition definition, MaterialComponentType value)
        {
            definition.SetField("materialComponentType", value);
            return definition;
        }

        public static SpellDefinition SetRequiresConcentration(this SpellDefinition definition, bool value)
        {
            definition.SetField("requiresConcentration", value);
            return definition;
        }

        public static SpellDefinition SetRitual(this SpellDefinition definition, bool value)
        {
            definition.SetField("ritual", value);
            return definition;
        }

        public static SpellDefinition SetRitualCastingTime(this SpellDefinition definition, ActivationTime value)
        {
            definition.SetField("ritualCastingTime", value);
            return definition;
        }

        public static SpellDefinition SetSchoolOfMagic(this SpellDefinition definition, string value)
        {
            definition.SetField("schoolOfMagic", value);
            return definition;
        }

        public static SpellDefinition SetSomaticComponent(this SpellDefinition definition, bool value)
        {
            definition.SetField("somaticComponent", value);
            return definition;
        }

        public static SpellDefinition SetSpecificMaterialComponentConsumed(this SpellDefinition definition, bool value)
        {
            definition.SetField("specificMaterialComponentConsumed", value);
            return definition;
        }

        public static SpellDefinition SetSpecificMaterialComponentCostGp(this SpellDefinition definition, int value)
        {
            definition.SetField("specificMaterialComponentCostGp", value);
            return definition;
        }

        public static SpellDefinition SetSpecificMaterialComponentTag(this SpellDefinition definition, string value)
        {
            definition.SetField("specificMaterialComponentTag", value);
            return definition;
        }

        public static SpellDefinition SetSpellLevel(this SpellDefinition definition, int value)
        {
            definition.SetField("spellLevel", value);
            return definition;
        }

        public static SpellDefinition SetSpellsBundle(this SpellDefinition definition, bool value)
        {
            definition.SetField("spellsBundle", value);
            return definition;
        }

        public static SpellDefinition SetSubspellsList(this SpellDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("subspellsList", value);
            return definition;
        }

        public static SpellDefinition SetUniqueInstance(this SpellDefinition definition, bool value)
        {
            definition.SetField("uniqueInstance", value);
            return definition;
        }

        public static SpellDefinition SetVerboseComponent(this SpellDefinition definition, bool value)
        {
            definition.SetField("verboseComponent", value);
            return definition;
        }
    }
}