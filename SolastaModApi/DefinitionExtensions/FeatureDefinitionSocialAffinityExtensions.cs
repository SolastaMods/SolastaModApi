using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionSocialAffinityExtensions
    {
        public static T SetOrganizationType<T>(this T definition, string value)
            where T : FeatureDefinitionSocialAffinity
        {
            definition.SetField("organizationType", value);
            return definition;
        }
    }
}