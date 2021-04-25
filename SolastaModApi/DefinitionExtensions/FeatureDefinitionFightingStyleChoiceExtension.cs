using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionFightingStyleChoiceExtensions
    {
        public static FeatureDefinitionFightingStyleChoice SetFightingStyles(this FeatureDefinitionFightingStyleChoice definition, List<string> value)
        {
            definition.SetField("fightingStyles", value);
            return definition;
        }
    }
}