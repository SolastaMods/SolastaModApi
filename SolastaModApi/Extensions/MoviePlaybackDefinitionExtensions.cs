using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class MoviePlaybackDefinitionExtensions
    {
        public static T SetMovieFilename<T>(this T entity, string value)
            where T : MoviePlaybackDefinition
        {
            entity.SetField("movieFilename", value);
            return entity;
        }
    }
}