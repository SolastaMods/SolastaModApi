using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class LegalStepDefinitionExtensions
    {
        public static T SetPreferenceKey<T>(this T entity, string value)
            where T : LegalStepDefinition
        {
            entity.SetField("preferenceKey", value);
            return entity;
        }

        public static T SetRequiresAgreement<T>(this T entity, bool value)
            where T : LegalStepDefinition
        {
            entity.SetField("requiresAgreement", value);
            return entity;
        }
    }
}