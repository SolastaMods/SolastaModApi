using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionLanguageAffinityExtensions
    {
        public static FeatureDefinitionLanguageAffinity SetKnownLanguages(this FeatureDefinitionLanguageAffinity definition, List<string> value)
        {
            definition.SetField("knownLanguages", value);
            return definition;
        }

        public static FeatureDefinitionLanguageAffinity SetUniversalReader(this FeatureDefinitionLanguageAffinity definition, bool value)
        {
            definition.SetField("universalReader", value);
            return definition;
        }
    }
}