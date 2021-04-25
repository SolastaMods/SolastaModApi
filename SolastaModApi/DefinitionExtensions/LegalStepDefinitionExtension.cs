using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class LegalStepDefinitionExtensions
    {
        public static LegalStepDefinition SetPreferenceKey(this LegalStepDefinition definition, string value)
        {
            definition.SetField("preferenceKey", value);
            return definition;
        }

        public static LegalStepDefinition SetRequiresAgreement(this LegalStepDefinition definition, bool value)
        {
            definition.SetField("requiresAgreement", value);
            return definition;
        }
    }
}