using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionSocialAffinityExtensions
    {
        public static FeatureDefinitionSocialAffinity SetOrganizationType(this FeatureDefinitionSocialAffinity definition, string value)
        {
            definition.SetField("organizationType", value);
            return definition;
        }

        public static FeatureDefinitionSocialAffinity SetSocialAffinityDuplets(this FeatureDefinitionSocialAffinity definition, List<FeatureDefinitionSocialAffinity.SocialAffinityDuplet> value)
        {
            definition.SetField("socialAffinityDuplets", value);
            return definition;
        }
    }
}