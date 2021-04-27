using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionCastSpellExtensions
    {
        public static T SetSlotsRecharge<T>(this T definition, RechargeRate value)
            where T : FeatureDefinitionCastSpell
        {
            definition.SetField("slotsRecharge", value);
            return definition;
        }

        public static T SetSpellcastingAbility<T>(this T definition, string value)
            where T : FeatureDefinitionCastSpell
        {
            definition.SetField("spellcastingAbility", value);
            return definition;
        }

        public static T SetSpellCastingLevel<T>(this T definition, int value)
            where T : FeatureDefinitionCastSpell
        {
            definition.SetField("spellCastingLevel", value);
            return definition;
        }

        public static T SetSpellCastingOrigin<T>(this T definition, FeatureDefinitionCastSpell.CastingOrigin value)
            where T : FeatureDefinitionCastSpell
        {
            definition.SetField("spellCastingOrigin", value);
            return definition;
        }

        public static T SetSpellcastingParametersComputation<T>(this T definition, SpellcastingParametersComputation value)
            where T : FeatureDefinitionCastSpell
        {
            definition.SetField("spellcastingParametersComputation", value);
            return definition;
        }

        public static T SetSpellKnowledge<T>(this T definition, SpellKnowledge value)
            where T : FeatureDefinitionCastSpell
        {
            definition.SetField("spellKnowledge", value);
            return definition;
        }

        public static T SetSpellListDefinition<T>(this T definition, SpellListDefinition value)
            where T : FeatureDefinitionCastSpell
        {
            definition.SetField("spellListDefinition", value);
            return definition;
        }

        public static T SetSpellPreparationCount<T>(this T definition, SpellPreparationCount value)
            where T : FeatureDefinitionCastSpell
        {
            definition.SetField("spellPreparationCount", value);
            return definition;
        }

        public static T SetSpellReadyness<T>(this T definition, SpellReadyness value)
            where T : FeatureDefinitionCastSpell
        {
            definition.SetField("spellReadyness", value);
            return definition;
        }

        public static T SetStaticDCValue<T>(this T definition, int value)
            where T : FeatureDefinitionCastSpell
        {
            definition.SetField("staticDCValue", value);
            return definition;
        }

        public static T SetStaticToHitValue<T>(this T definition, int value)
            where T : FeatureDefinitionCastSpell
        {
            definition.SetField("staticToHitValue", value);
            return definition;
        }
    }
}