using SolastaModApi.Infrastructure;
using AK.Wwise;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MusicalStateDefinitionExtensions
    {
        public static void SetAudioStateLocation(this MusicalStateDefinition definition, State value)
        {
            definition.SetField("audioStateLocation", value);
        }

        public static void SetAudioStateZone(this MusicalStateDefinition definition, State value)
        {
            definition.SetField("audioStateZone", value);
        }
    }
}