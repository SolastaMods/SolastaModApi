using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MoviePlaybackDefinitionExtensions
    {
        public static MoviePlaybackDefinition SetMovieFilename(this MoviePlaybackDefinition definition, string value)
        {
            definition.SetField("movieFilename", value);
            return definition;
        }

        public static MoviePlaybackDefinition SetSubtitleOccurences(this MoviePlaybackDefinition definition, List<SubtitleOccurenceDescription> value)
        {
            definition.SetField("subtitleOccurences", value);
            return definition;
        }
    }
}