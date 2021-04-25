using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class LegalStepDefinitionExtensions
    {
        public static void SetPreferenceKey(this LegalStepDefinition definition, String value)
        {
            definition.SetField("preferenceKey", value);
        }

        public static void SetRequiresAgreement(this LegalStepDefinition definition, Boolean value)
        {
            definition.SetField("requiresAgreement", value);
        }
    }
}