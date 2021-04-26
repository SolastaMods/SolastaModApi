using SolastaModApi.Infrastructure;
using System.Collections.Generic;

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

        public static T SetSocialAffinityDuplets<T>(this T definition, List<FeatureDefinitionSocialAffinity.SocialAffinityDuplet> value)
            where T : FeatureDefinitionSocialAffinity
        {
            definition.SetField("socialAffinityDuplets", value);
            return definition;
        }
    }
}