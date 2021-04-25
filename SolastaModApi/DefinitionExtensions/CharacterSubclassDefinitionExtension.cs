using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CharacterSubclassDefinitionExtensions
    {
        public static CharacterSubclassDefinition SetFeatureUnlocks(this CharacterSubclassDefinition definition, List<FeatureUnlockByLevel> value)
        {
            definition.SetField("featureUnlocks", value);
            return definition;
        }

        public static CharacterSubclassDefinition SetPersonalityFlagOccurences(this CharacterSubclassDefinition definition, List<PersonalityFlagOccurence> value)
        {
            definition.SetField("personalityFlagOccurences", value);
            return definition;
        }
    }
}