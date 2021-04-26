using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class NarrativeEventTableDefinitionExtensions
    {
        public static T SetEventDescriptions<T>(this T definition, List<NarrativeEventDescription> value)
            where T : NarrativeEventTableDefinition
        {
            definition.SetField("eventDescriptions", value);
            return definition;
        }
    }
}