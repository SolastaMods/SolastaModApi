using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CharacterSubclassDefinitionExtensions
    {
        public static void SetFeatureUnlocks(this CharacterSubclassDefinition definition, List<FeatureUnlockByLevel> value)
        {
            definition.SetField("featureUnlocks", value);
        }

        public static void SetPersonalityFlagOccurences(this CharacterSubclassDefinition definition, List<PersonalityFlagOccurence> value)
        {
            definition.SetField("personalityFlagOccurences", value);
        }
    }
}