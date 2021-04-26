using SolastaModApi.Infrastructure;
using System.Collections.Generic;

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

        public static T SetSubtitleOccurences<T>(this T definition, List<SubtitleOccurenceDescription> value)
            where T : MoviePlaybackDefinition
        {
            definition.SetField("subtitleOccurences", value);
            return definition;
        }
    }
}