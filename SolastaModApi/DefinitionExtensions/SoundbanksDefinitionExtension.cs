using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class SoundbanksDefinitionExtensions
    {
        public static void SetRawEventDurations(this SoundbanksDefinition definition, List<SoundbanksDefinition.EventDurations> value)
        {
            definition.SetField("rawEventDurations", value);
        }
    }
}