using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionFightingStyleChoiceExtensions
    {
        public static void SetFightingStyles(this FeatureDefinitionFightingStyleChoice definition, List<String> value)
        {
            definition.SetField("fightingStyles", value);
        }
    }
}