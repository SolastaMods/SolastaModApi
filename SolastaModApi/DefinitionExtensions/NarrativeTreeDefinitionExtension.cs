using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class NarrativeTreeDefinitionExtensions
    {
        public static NarrativeTreeDefinition SetAllNarrativeStateDescriptions(this NarrativeTreeDefinition definition, List<NarrativeStateDescription> value)
        {
            definition.SetField("allNarrativeStateDescriptions", value);
            return definition;
        }
    }
}