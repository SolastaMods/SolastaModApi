using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class LegalStepDefinitionExtensions
    {
        public static T SetPreferenceKey<T>(this T definition, string value)
            where T : LegalStepDefinition
        {
            definition.SetField("preferenceKey", value);
            return definition;
        }

        public static T SetRequiresAgreement<T>(this T definition, bool value)
            where T : LegalStepDefinition
        {
            definition.SetField("requiresAgreement", value);
            return definition;
        }
    }
}