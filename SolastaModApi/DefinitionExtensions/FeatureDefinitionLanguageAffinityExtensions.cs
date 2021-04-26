using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class FeatureDefinitionLanguageAffinityExtensions
    {
        public static T SetKnownLanguages<T>(this T definition, List<string> value)
            where T : FeatureDefinitionLanguageAffinity
        {
            definition.SetField("knownLanguages", value);
            return definition;
        }

        public static T SetUniversalReader<T>(this T definition, bool value)
            where T : FeatureDefinitionLanguageAffinity
        {
            definition.SetField("universalReader", value);
            return definition;
        }
    }
}