using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class RecordTableDefinitionExtensions
    {
        public static T SetAreaWidth<T>(this T entity, float value)
            where T : RecordTableDefinition
        {
            entity.SetField("areaWidth", value);
            return entity;
        }

        public static T SetLayout<T>(this T entity, RecordTableDefinition.LayoutType value)
            where T : RecordTableDefinition
        {
            entity.SetField("layout", value);
            return entity;
        }

        public static T SetMaxEntries<T>(this T entity, int value)
            where T : RecordTableDefinition
        {
            entity.SetField("maxEntries", value);
            return entity;
        }

        public static T SetMaxSerializedEntries<T>(this T entity, int value)
            where T : RecordTableDefinition
        {
            entity.SetField("maxSerializedEntries", value);
            return entity;
        }

        public static T SetOffsetX<T>(this T entity, float value)
            where T : RecordTableDefinition
        {
            entity.SetField("offsetX", value);
            return entity;
        }

        public static T SetOffsetY<T>(this T entity, float value)
            where T : RecordTableDefinition
        {
            entity.SetField("offsetY", value);
            return entity;
        }

        public static T SetSpacing<T>(this T entity, float value)
            where T : RecordTableDefinition
        {
            entity.SetField("spacing", value);
            return entity;
        }
    }
}