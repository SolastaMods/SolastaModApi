using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionLanguageAffinityExtensions
    {
        public static void SetKnownLanguages(this FeatureDefinitionLanguageAffinity definition, List<String> value)
        {
            definition.SetField("knownLanguages", value);
        }

        public static void SetUniversalReader(this FeatureDefinitionLanguageAffinity definition, Boolean value)
        {
            definition.SetField("universalReader", value);
        }
    }
}