using SolastaModApi.Infrastructure;
using static ActionDefinitions;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class SpellDefinitionExtensions
    {
        public static T SetAiParameters<T>(this T entity, SpellAIParameters value)
            where T : SpellDefinition
        {
            entity.SetField("aiParameters", value);
            return entity;
        }

        public static T SetCastingTime<T>(this T entity, ActivationTime value)
            where T : SpellDefinition
        {
            entity.SetField("castingTime", value);
            return entity;
        }

        public static T SetConcentrationAction<T>(this T entity, ActionParameter value)
            where T : SpellDefinition
        {
            entity.SetField("concentrationAction", value);
            return entity;
        }

        public static T SetEffectDescription<T>(this T entity, EffectDescription value)
            where T : SpellDefinition
        {
            entity.SetField("effectDescription", value);
            return entity;
        }

        public static T SetImplemented<T>(this T entity, bool value)
            where T : SpellDefinition
        {
            entity.SetField("implemented", value);
            return entity;
        }

        public static T SetMaterialComponentType<T>(this T entity, MaterialComponentType value)
            where T : SpellDefinition
        {
            entity.SetField("materialComponentType", value);
            return entity;
        }

        public static T SetRequiresConcentration<T>(this T entity, bool value)
            where T : SpellDefinition
        {
            entity.SetField("requiresConcentration", value);
            return entity;
        }

        public static T SetRitual<T>(this T entity, bool value)
            where T : SpellDefinition
        {
            entity.SetField("ritual", value);
            return entity;
        }

        public static T SetRitualCastingTime<T>(this T entity, ActivationTime value)
            where T : SpellDefinition
        {
            entity.SetField("ritualCastingTime", value);
            return entity;
        }

        public static T SetSchoolOfMagic<T>(this T entity, string value)
            where T : SpellDefinition
        {
            entity.SetField("schoolOfMagic", value);
            return entity;
        }

        public static T SetSomaticComponent<T>(this T entity, bool value)
            where T : SpellDefinition
        {
            entity.SetField("somaticComponent", value);
            return entity;
        }

        public static T SetSpecificMaterialComponentConsumed<T>(this T entity, bool value)
            where T : SpellDefinition
        {
            entity.SetField("specificMaterialComponentConsumed", value);
            return entity;
        }

        public static T SetSpecificMaterialComponentCostGp<T>(this T entity, int value)
            where T : SpellDefinition
        {
            entity.SetField("specificMaterialComponentCostGp", value);
            return entity;
        }

        public static T SetSpecificMaterialComponentTag<T>(this T entity, string value)
            where T : SpellDefinition
        {
            entity.SetField("specificMaterialComponentTag", value);
            return entity;
        }

        public static T SetSpellLevel<T>(this T entity, int value)
            where T : SpellDefinition
        {
            entity.SetField("spellLevel", value);
            return entity;
        }

        public static T SetSpellsBundle<T>(this T entity, bool value)
            where T : SpellDefinition
        {
            entity.SetField("spellsBundle", value);
            return entity;
        }

        public static T SetUniqueInstance<T>(this T entity, bool value)
            where T : SpellDefinition
        {
            entity.SetField("uniqueInstance", value);
            return entity;
        }

        public static T SetVerboseComponent<T>(this T entity, bool value)
            where T : SpellDefinition
        {
            entity.SetField("verboseComponent", value);
            return entity;
        }
    }
}