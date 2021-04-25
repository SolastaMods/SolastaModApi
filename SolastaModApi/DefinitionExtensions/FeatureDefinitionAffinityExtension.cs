using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionAffinityExtensions
    {
        public static FeatureDefinitionAffinity SetMyselfFamilyRestrictions(this FeatureDefinitionAffinity definition, List<string> value)
        {
            definition.SetField("myselfFamilyRestrictions", value);
            return definition;
        }

        public static FeatureDefinitionAffinity SetOtherCharacterFamilyRestrictions(this FeatureDefinitionAffinity definition, List<string> value)
        {
            definition.SetField("otherCharacterFamilyRestrictions", value);
            return definition;
        }
    }
}