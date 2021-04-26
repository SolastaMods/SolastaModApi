using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class BestiaryTableDefinitionExtensions
    {
        public static T SetCellHeight<T>(this T definition, float value)
            where T : BestiaryTableDefinition
        {
            definition.SetField("cellHeight", value);
            return definition;
        }

        public static T SetCellWidth<T>(this T definition, float value)
            where T : BestiaryTableDefinition
        {
            definition.SetField("cellWidth", value);
            return definition;
        }
    }
}