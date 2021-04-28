using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionSocialAffinityExtensions
    {
        public static T SetOrganizationType<T>(this T entity, string value)
            where T : FeatureDefinitionSocialAffinity
        {
            entity.SetField("organizationType", value);
            return entity;
        }
    }
}