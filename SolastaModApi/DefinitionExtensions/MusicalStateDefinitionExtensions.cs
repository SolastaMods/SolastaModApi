using SolastaModApi.Infrastructure;
using AK.Wwise;

namespace SolastaModApi
{
    public static class MusicalStateDefinitionExtensions
    {
        public static T SetAudioStateLocation<T>(this T definition, State value)
            where T : MusicalStateDefinition
        {
            definition.SetField("audioStateLocation", value);
            return definition;
        }

        public static T SetAudioStateZone<T>(this T definition, State value)
            where T : MusicalStateDefinition
        {
            definition.SetField("audioStateZone", value);
            return definition;
        }
    }
}