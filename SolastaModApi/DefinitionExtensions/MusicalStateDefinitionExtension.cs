using SolastaModApi.Infrastructure;
using AK.Wwise;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MusicalStateDefinitionExtensions
    {
        public static MusicalStateDefinition SetAudioStateLocation(this MusicalStateDefinition definition, State value)
        {
            definition.SetField("audioStateLocation", value);
            return definition;
        }

        public static MusicalStateDefinition SetAudioStateZone(this MusicalStateDefinition definition, State value)
        {
            definition.SetField("audioStateZone", value);
            return definition;
        }
    }
}