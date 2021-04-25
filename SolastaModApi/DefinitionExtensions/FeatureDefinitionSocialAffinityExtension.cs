using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionSocialAffinityExtensions
    {
        public static void SetOrganizationType(this FeatureDefinitionSocialAffinity definition, String value)
        {
            definition.SetField("organizationType", value);
        }

        public static void SetSocialAffinityDuplets(this FeatureDefinitionSocialAffinity definition, List<FeatureDefinitionSocialAffinity.SocialAffinityDuplet> value)
        {
            definition.SetField("socialAffinityDuplets", value);
        }
    }
}