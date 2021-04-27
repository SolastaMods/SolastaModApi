using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class MoviePlaybackDefinitionExtensions
    {
        public static T SetMovieFilename<T>(this T definition, string value)
            where T : MoviePlaybackDefinition
        {
            definition.SetField("movieFilename", value);
            return definition;
        }
    }
}