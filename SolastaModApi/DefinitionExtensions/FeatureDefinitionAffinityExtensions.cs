using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class FeatureDefinitionAffinityExtensions
    {
        public static T SetMyselfFamilyRestrictions<T>(this T definition, List<string> value)
            where T : FeatureDefinitionAffinity
        {
            definition.SetField("myselfFamilyRestrictions", value);
            return definition;
        }

        public static T SetOtherCharacterFamilyRestrictions<T>(this T definition, List<string> value)
            where T : FeatureDefinitionAffinity
        {
            definition.SetField("otherCharacterFamilyRestrictions", value);
            return definition;
        }
    }
}