using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class BestiaryTableDefinitionExtensions
    {
        public static void SetCellHeight(this BestiaryTableDefinition definition, Single value)
        {
            definition.SetField("cellHeight", value);
        }

        public static void SetCellWidth(this BestiaryTableDefinition definition, Single value)
        {
            definition.SetField("cellWidth", value);
        }
    }
}