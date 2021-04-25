using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class EncounterTableDefinitionExtensions
    {
        public static EncounterTableDefinition SetEncounterOccurences(this EncounterTableDefinition definition, List<EncounterOccurenceDescription> value)
        {
            definition.SetField("encounterOccurences", value);
            return definition;
        }
    }
}