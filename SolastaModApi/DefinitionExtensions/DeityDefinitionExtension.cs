using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DeityDefinitionExtensions
    {
        public static void SetAlignment(this DeityDefinition definition, String value)
        {
            definition.SetField("alignment", value);
        }

        public static void SetPersonalityFlagOccurences(this DeityDefinition definition, List<PersonalityFlagOccurence> value)
        {
            definition.SetField("personalityFlagOccurences", value);
        }

        public static void SetSelectableByPlayer(this DeityDefinition definition, Boolean value)
        {
            definition.SetField("selectableByPlayer", value);
        }

        public static void SetSubclasses(this DeityDefinition definition, List<String> value)
        {
            definition.SetField("subclasses", value);
        }
    }
}