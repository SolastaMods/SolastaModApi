using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class SpellDefinitionExtensions
    {
        public static void SetAiParameters(this SpellDefinition definition, SpellAIParameters value)
        {
            definition.SetField("aiParameters", value);
        }

        public static void SetCastingTime(this SpellDefinition definition, ActivationTime value)
        {
            definition.SetField("castingTime", value);
        }

        public static void SetConcentrationAction(this SpellDefinition definition, ActionParameter value)
        {
            definition.SetField("concentrationAction", value);
        }

        public static void SetEffectDescription(this SpellDefinition definition, EffectDescription value)
        {
            definition.SetField("effectDescription", value);
        }

        public static void SetImplemented(this SpellDefinition definition, Boolean value)
        {
            definition.SetField("implemented", value);
        }

        public static void SetMaterialComponentType(this SpellDefinition definition, MaterialComponentType value)
        {
            definition.SetField("materialComponentType", value);
        }

        public static void SetRequiresConcentration(this SpellDefinition definition, Boolean value)
        {
            definition.SetField("requiresConcentration", value);
        }

        public static void SetRitual(this SpellDefinition definition, Boolean value)
        {
            definition.SetField("ritual", value);
        }

        public static void SetRitualCastingTime(this SpellDefinition definition, ActivationTime value)
        {
            definition.SetField("ritualCastingTime", value);
        }

        public static void SetSchoolOfMagic(this SpellDefinition definition, String value)
        {
            definition.SetField("schoolOfMagic", value);
        }

        public static void SetSomaticComponent(this SpellDefinition definition, Boolean value)
        {
            definition.SetField("somaticComponent", value);
        }

        public static void SetSpecificMaterialComponentConsumed(this SpellDefinition definition, Boolean value)
        {
            definition.SetField("specificMaterialComponentConsumed", value);
        }

        public static void SetSpecificMaterialComponentCostGp(this SpellDefinition definition, Int32 value)
        {
            definition.SetField("specificMaterialComponentCostGp", value);
        }

        public static void SetSpecificMaterialComponentTag(this SpellDefinition definition, String value)
        {
            definition.SetField("specificMaterialComponentTag", value);
        }

        public static void SetSpellLevel(this SpellDefinition definition, Int32 value)
        {
            definition.SetField("spellLevel", value);
        }

        public static void SetSpellsBundle(this SpellDefinition definition, Boolean value)
        {
            definition.SetField("spellsBundle", value);
        }

        public static void SetSubspellsList(this SpellDefinition definition, List<SpellDefinition> value)
        {
            definition.SetField("subspellsList", value);
        }

        public static void SetUniqueInstance(this SpellDefinition definition, Boolean value)
        {
            definition.SetField("uniqueInstance", value);
        }

        public static void SetVerboseComponent(this SpellDefinition definition, Boolean value)
        {
            definition.SetField("verboseComponent", value);
        }
    }
}