using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DeityDefinitionExtensions
    {
        public static DeityDefinition SetAlignment(this DeityDefinition definition, string value)
        {
            definition.SetField("alignment", value);
            return definition;
        }

        public static DeityDefinition SetPersonalityFlagOccurences(this DeityDefinition definition, List<PersonalityFlagOccurence> value)
        {
            definition.SetField("personalityFlagOccurences", value);
            return definition;
        }

        public static DeityDefinition SetSelectableByPlayer(this DeityDefinition definition, bool value)
        {
            definition.SetField("selectableByPlayer", value);
            return definition;
        }

        public static DeityDefinition SetSubclasses(this DeityDefinition definition, List<string> value)
        {
            definition.SetField("subclasses", value);
            return definition;
        }
    }
}