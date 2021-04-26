using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class EncounterTableDefinitionExtensions
    {
        public static T SetEncounterOccurences<T>(this T definition, List<EncounterOccurenceDescription> value)
            where T : EncounterTableDefinition
        {
            definition.SetField("encounterOccurences", value);
            return definition;
        }
    }
}