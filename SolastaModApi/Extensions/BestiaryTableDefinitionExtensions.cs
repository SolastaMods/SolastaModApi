using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class BestiaryTableDefinitionExtensions
    {
        public static T SetCellHeight<T>(this T entity, float value)
            where T : BestiaryTableDefinition
        {
            entity.SetField("cellHeight", value);
            return entity;
        }

        public static T SetCellWidth<T>(this T entity, float value)
            where T : BestiaryTableDefinition
        {
            entity.SetField("cellWidth", value);
            return entity;
        }
    }
}