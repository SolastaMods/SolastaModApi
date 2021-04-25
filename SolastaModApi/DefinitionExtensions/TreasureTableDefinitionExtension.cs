using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class TreasureTableDefinitionExtensions
    {
        public static TreasureTableDefinition SetTreasureOptions(this TreasureTableDefinition definition, List<TreasureOption> value)
        {
            definition.SetField("treasureOptions", value);
            return definition;
        }
    }
}