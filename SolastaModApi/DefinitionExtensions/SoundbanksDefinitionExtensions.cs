using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class SoundbanksDefinitionExtensions
    {
        public static T SetRawEventDurations<T>(this T definition, List<SoundbanksDefinition.EventDurations> value)
            where T : SoundbanksDefinition
        {
            definition.SetField("rawEventDurations", value);
            return definition;
        }
    }
}