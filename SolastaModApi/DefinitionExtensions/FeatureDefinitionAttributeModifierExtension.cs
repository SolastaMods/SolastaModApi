using SolastaModApi.Infrastructure;
using System;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionAttributeModifierExtensions
    {
        public static void SetModifiedAttribute(this FeatureDefinitionAttributeModifier definition, String value)
        {
            definition.SetField("modifiedAttribute", value);
        }

        public static void SetModifierType(this FeatureDefinitionAttributeModifier definition, FeatureDefinitionAttributeModifier.AttributeModifierOperationOld value)
        {
            definition.SetField("modifierType", value);
        }

        public static void SetModifierType2(this FeatureDefinitionAttributeModifier definition, FeatureDefinitionAttributeModifier.AttributeModifierOperation value)
        {
            definition.SetField("modifierType2", value);
        }

        public static void SetModifierValue(this FeatureDefinitionAttributeModifier definition, Int32 value)
        {
            definition.SetField("modifierValue", value);
        }

        public static void SetSituationalContext(this FeatureDefinitionAttributeModifier definition, SituationalContext value)
        {
            definition.SetField("situationalContext", value);
        }
    }
}