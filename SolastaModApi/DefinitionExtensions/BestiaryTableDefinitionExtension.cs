using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class BestiaryTableDefinitionExtensions
    {
        public static BestiaryTableDefinition SetCellHeight(this BestiaryTableDefinition definition, float value)
        {
            definition.SetField("cellHeight", value);
            return definition;
        }

        public static BestiaryTableDefinition SetCellWidth(this BestiaryTableDefinition definition, float value)
        {
            definition.SetField("cellWidth", value);
            return definition;
        }
    }
}