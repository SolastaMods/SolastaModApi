using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionAffinityExtensions
    {
        public static void SetMyselfFamilyRestrictions(this FeatureDefinitionAffinity definition, List<String> value)
        {
            definition.SetField("myselfFamilyRestrictions", value);
        }

        public static void SetOtherCharacterFamilyRestrictions(this FeatureDefinitionAffinity definition, List<String> value)
        {
            definition.SetField("otherCharacterFamilyRestrictions", value);
        }
    }
}