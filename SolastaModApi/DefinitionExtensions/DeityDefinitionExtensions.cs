using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class DeityDefinitionExtensions
    {
        public static T SetAlignment<T>(this T definition, string value)
            where T : DeityDefinition
        {
            definition.SetField("alignment", value);
            return definition;
        }

        public static T SetPersonalityFlagOccurences<T>(this T definition, List<PersonalityFlagOccurence> value)
            where T : DeityDefinition
        {
            definition.SetField("personalityFlagOccurences", value);
            return definition;
        }

        public static T SetSelectableByPlayer<T>(this T definition, bool value)
            where T : DeityDefinition
        {
            definition.SetField("selectableByPlayer", value);
            return definition;
        }

        public static T SetSubclasses<T>(this T definition, List<string> value)
            where T : DeityDefinition
        {
            definition.SetField("subclasses", value);
            return definition;
        }
    }
}