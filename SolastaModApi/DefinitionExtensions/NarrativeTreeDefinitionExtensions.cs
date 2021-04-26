using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class NarrativeTreeDefinitionExtensions
    {
        public static T SetAllNarrativeStateDescriptions<T>(this T definition, List<NarrativeStateDescription> value)
            where T : NarrativeTreeDefinition
        {
            definition.SetField("allNarrativeStateDescriptions", value);
            return definition;
        }
    }
}