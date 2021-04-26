using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class FeatureDefinitionFightingStyleChoiceExtensions
    {
        public static T SetFightingStyles<T>(this T definition, List<string> value)
            where T : FeatureDefinitionFightingStyleChoice
        {
            definition.SetField("fightingStyles", value);
            return definition;
        }
    }
}