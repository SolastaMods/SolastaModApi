using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class CharacterSubclassDefinitionExtensions
    {
        public static T SetFeatureUnlocks<T>(this T definition, List<FeatureUnlockByLevel> value)
            where T : CharacterSubclassDefinition
        {
            definition.SetField("featureUnlocks", value);
            return definition;
        }

        public static T SetPersonalityFlagOccurences<T>(this T definition, List<PersonalityFlagOccurence> value)
            where T : CharacterSubclassDefinition
        {
            definition.SetField("personalityFlagOccurences", value);
            return definition;
        }
    }
}