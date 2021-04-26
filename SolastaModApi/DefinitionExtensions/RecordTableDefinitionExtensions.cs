using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class RecordTableDefinitionExtensions
    {
        public static T SetAreaWidth<T>(this T definition, float value)
            where T : RecordTableDefinition
        {
            definition.SetField("areaWidth", value);
            return definition;
        }

        public static T SetLayout<T>(this T definition, RecordTableDefinition.LayoutType value)
            where T : RecordTableDefinition
        {
            definition.SetField("layout", value);
            return definition;
        }

        public static T SetMaxEntries<T>(this T definition, int value)
            where T : RecordTableDefinition
        {
            definition.SetField("maxEntries", value);
            return definition;
        }

        public static T SetMaxSerializedEntries<T>(this T definition, int value)
            where T : RecordTableDefinition
        {
            definition.SetField("maxSerializedEntries", value);
            return definition;
        }

        public static T SetOffsetX<T>(this T definition, float value)
            where T : RecordTableDefinition
        {
            definition.SetField("offsetX", value);
            return definition;
        }

        public static T SetOffsetY<T>(this T definition, float value)
            where T : RecordTableDefinition
        {
            definition.SetField("offsetY", value);
            return definition;
        }

        public static T SetSpacing<T>(this T definition, float value)
            where T : RecordTableDefinition
        {
            definition.SetField("spacing", value);
            return definition;
        }
    }
}