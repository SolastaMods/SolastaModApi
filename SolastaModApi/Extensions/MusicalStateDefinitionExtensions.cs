using SolastaModApi.Infrastructure;
using AK.Wwise;

namespace SolastaModApi
{
    public static class MusicalStateDefinitionExtensions
    {
        public static T SetAudioStateLocation<T>(this T entity, State value)
            where T : MusicalStateDefinition
        {
            entity.SetField("audioStateLocation", value);
            return entity;
        }

        public static T SetAudioStateZone<T>(this T entity, State value)
            where T : MusicalStateDefinition
        {
            entity.SetField("audioStateZone", value);
            return entity;
        }
    }
}