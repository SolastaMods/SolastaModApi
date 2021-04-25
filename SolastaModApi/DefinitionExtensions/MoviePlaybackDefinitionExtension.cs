using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MoviePlaybackDefinitionExtensions
    {
        public static void SetMovieFilename(this MoviePlaybackDefinition definition, String value)
        {
            definition.SetField("movieFilename", value);
        }

        public static void SetSubtitleOccurences(this MoviePlaybackDefinition definition, List<SubtitleOccurenceDescription> value)
        {
            definition.SetField("subtitleOccurences", value);
        }
    }
}