using SolastaModApi.Infrastructure;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class SpellDefinitionExtensions
    {
        public static T SetAiParameters<T>(this T definition, SpellAIParameters value)
            where T : SpellDefinition
        {
            definition.SetField("aiParameters", value);
            return definition;
        }

        public static T SetCastingTime<T>(this T definition, ActivationTime value)
            where T : SpellDefinition
        {
            definition.SetField("castingTime", value);
            return definition;
        }

        public static T SetConcentrationAction<T>(this T definition, ActionParameter value)
            where T : SpellDefinition
        {
            definition.SetField("concentrationAction", value);
            return definition;
        }

        public static T SetEffectDescription<T>(this T definition, EffectDescription value)
            where T : SpellDefinition
        {
            definition.SetField("effectDescription", value);
            return definition;
        }

        public static T SetImplemented<T>(this T definition, bool value)
            where T : SpellDefinition
        {
            definition.SetField("implemented", value);
            return definition;
        }

        public static T SetMaterialComponentType<T>(this T definition, MaterialComponentType value)
            where T : SpellDefinition
        {
            definition.SetField("materialComponentType", value);
            return definition;
        }

        public static T SetRequiresConcentration<T>(this T definition, bool value)
            where T : SpellDefinition
        {
            definition.SetField("requiresConcentration", value);
            return definition;
        }

        public static T SetRitual<T>(this T definition, bool value)
            where T : SpellDefinition
        {
            definition.SetField("ritual", value);
            return definition;
        }

        public static T SetRitualCastingTime<T>(this T definition, ActivationTime value)
            where T : SpellDefinition
        {
            definition.SetField("ritualCastingTime", value);
            return definition;
        }

        public static T SetSchoolOfMagic<T>(this T definition, string value)
            where T : SpellDefinition
        {
            definition.SetField("schoolOfMagic", value);
            return definition;
        }

        public static T SetSomaticComponent<T>(this T definition, bool value)
            where T : SpellDefinition
        {
            definition.SetField("somaticComponent", value);
            return definition;
        }

        public static T SetSpecificMaterialComponentConsumed<T>(this T definition, bool value)
            where T : SpellDefinition
        {
            definition.SetField("specificMaterialComponentConsumed", value);
            return definition;
        }

        public static T SetSpecificMaterialComponentCostGp<T>(this T definition, int value)
            where T : SpellDefinition
        {
            definition.SetField("specificMaterialComponentCostGp", value);
            return definition;
        }

        public static T SetSpecificMaterialComponentTag<T>(this T definition, string value)
            where T : SpellDefinition
        {
            definition.SetField("specificMaterialComponentTag", value);
            return definition;
        }

        public static T SetSpellLevel<T>(this T definition, int value)
            where T : SpellDefinition
        {
            definition.SetField("spellLevel", value);
            return definition;
        }

        public static T SetSpellsBundle<T>(this T definition, bool value)
            where T : SpellDefinition
        {
            definition.SetField("spellsBundle", value);
            return definition;
        }

        public static T SetUniqueInstance<T>(this T definition, bool value)
            where T : SpellDefinition
        {
            definition.SetField("uniqueInstance", value);
            return definition;
        }

        public static T SetVerboseComponent<T>(this T definition, bool value)
            where T : SpellDefinition
        {
            definition.SetField("verboseComponent", value);
            return definition;
        }
    }
}