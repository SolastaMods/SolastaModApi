using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionAttributeModifierExtensions
    {
        public static T SetModifiedAttribute<T>(this T definition, string value)
            where T : FeatureDefinitionAttributeModifier
        {
            definition.SetField("modifiedAttribute", value);
            return definition;
        }

        public static T SetModifierType<T>(this T definition, FeatureDefinitionAttributeModifier.AttributeModifierOperationOld value)
            where T : FeatureDefinitionAttributeModifier
        {
            definition.SetField("modifierType", value);
            return definition;
        }

        public static T SetModifierType2<T>(this T definition, FeatureDefinitionAttributeModifier.AttributeModifierOperation value)
            where T : FeatureDefinitionAttributeModifier
        {
            definition.SetField("modifierType2", value);
            return definition;
        }

        public static T SetModifierValue<T>(this T definition, int value)
            where T : FeatureDefinitionAttributeModifier
        {
            definition.SetField("modifierValue", value);
            return definition;
        }

        public static T SetSituationalContext<T>(this T definition, SituationalContext value)
            where T : FeatureDefinitionAttributeModifier
        {
            definition.SetField("situationalContext", value);
            return definition;
        }
    }
}