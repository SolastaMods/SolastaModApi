using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionCastSpellExtensions
    {
        public static T SetSlotsRecharge<T>(this T entity, RechargeRate value)
            where T : FeatureDefinitionCastSpell
        {
            entity.SetField("slotsRecharge", value);
            return entity;
        }

        public static T SetSpellcastingAbility<T>(this T entity, string value)
            where T : FeatureDefinitionCastSpell
        {
            entity.SetField("spellcastingAbility", value);
            return entity;
        }

        public static T SetSpellCastingLevel<T>(this T entity, int value)
            where T : FeatureDefinitionCastSpell
        {
            entity.SetField("spellCastingLevel", value);
            return entity;
        }

        public static T SetSpellCastingOrigin<T>(this T entity, FeatureDefinitionCastSpell.CastingOrigin value)
            where T : FeatureDefinitionCastSpell
        {
            entity.SetField("spellCastingOrigin", value);
            return entity;
        }

        public static T SetSpellcastingParametersComputation<T>(this T entity, SpellcastingParametersComputation value)
            where T : FeatureDefinitionCastSpell
        {
            entity.SetField("spellcastingParametersComputation", value);
            return entity;
        }

        public static T SetSpellKnowledge<T>(this T entity, SpellKnowledge value)
            where T : FeatureDefinitionCastSpell
        {
            entity.SetField("spellKnowledge", value);
            return entity;
        }

        public static T SetSpellListDefinition<T>(this T entity, SpellListDefinition value)
            where T : FeatureDefinitionCastSpell
        {
            entity.SetField("spellListDefinition", value);
            return entity;
        }

        public static T SetSpellPreparationCount<T>(this T entity, SpellPreparationCount value)
            where T : FeatureDefinitionCastSpell
        {
            entity.SetField("spellPreparationCount", value);
            return entity;
        }

        public static T SetSpellReadyness<T>(this T entity, SpellReadyness value)
            where T : FeatureDefinitionCastSpell
        {
            entity.SetField("spellReadyness", value);
            return entity;
        }

        public static T SetStaticDCValue<T>(this T entity, int value)
            where T : FeatureDefinitionCastSpell
        {
            entity.SetField("staticDCValue", value);
            return entity;
        }

        public static T SetStaticToHitValue<T>(this T entity, int value)
            where T : FeatureDefinitionCastSpell
        {
            entity.SetField("staticToHitValue", value);
            return entity;
        }
    }
}