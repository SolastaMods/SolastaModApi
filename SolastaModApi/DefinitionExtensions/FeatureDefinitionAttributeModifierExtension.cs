using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionAttributeModifierExtensions
    {
        public static FeatureDefinitionAttributeModifier SetModifiedAttribute(this FeatureDefinitionAttributeModifier definition, string value)
        {
            definition.SetField("modifiedAttribute", value);
            return definition;
        }

        public static FeatureDefinitionAttributeModifier SetModifierType(this FeatureDefinitionAttributeModifier definition, FeatureDefinitionAttributeModifier.AttributeModifierOperationOld value)
        {
            definition.SetField("modifierType", value);
            return definition;
        }

        public static FeatureDefinitionAttributeModifier SetModifierType2(this FeatureDefinitionAttributeModifier definition, FeatureDefinitionAttributeModifier.AttributeModifierOperation value)
        {
            definition.SetField("modifierType2", value);
            return definition;
        }

        public static FeatureDefinitionAttributeModifier SetModifierValue(this FeatureDefinitionAttributeModifier definition, int value)
        {
            definition.SetField("modifierValue", value);
            return definition;
        }

        public static FeatureDefinitionAttributeModifier SetSituationalContext(this FeatureDefinitionAttributeModifier definition, SituationalContext value)
        {
            definition.SetField("situationalContext", value);
            return definition;
        }
    }
}