using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class TreasureTableDefinitionExtensions
    {
        public static T SetTreasureOptions<T>(this T definition, List<TreasureOption> value)
            where T : TreasureTableDefinition
        {
            definition.SetField("treasureOptions", value);
            return definition;
        }
    }
}