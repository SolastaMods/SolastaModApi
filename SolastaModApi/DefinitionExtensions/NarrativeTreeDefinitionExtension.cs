using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class NarrativeTreeDefinitionExtensions
    {
        public static void SetAllNarrativeStateDescriptions(this NarrativeTreeDefinition definition, List<NarrativeStateDescription> value)
        {
            definition.SetField("allNarrativeStateDescriptions", value);
        }
    }
}