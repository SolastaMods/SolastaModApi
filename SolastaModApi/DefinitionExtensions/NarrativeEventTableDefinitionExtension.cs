using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class NarrativeEventTableDefinitionExtensions
    {
        public static void SetEventDescriptions(this NarrativeEventTableDefinition definition, List<NarrativeEventDescription> value)
        {
            definition.SetField("eventDescriptions", value);
        }
    }
}