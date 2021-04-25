using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class RecordTableDefinitionExtensions
    {
        public static RecordTableDefinition SetAreaWidth(this RecordTableDefinition definition, float value)
        {
            definition.SetField("areaWidth", value);
            return definition;
        }

        public static RecordTableDefinition SetLayout(this RecordTableDefinition definition, RecordTableDefinition.LayoutType value)
        {
            definition.SetField("layout", value);
            return definition;
        }

        public static RecordTableDefinition SetMaxEntries(this RecordTableDefinition definition, int value)
        {
            definition.SetField("maxEntries", value);
            return definition;
        }

        public static RecordTableDefinition SetMaxSerializedEntries(this RecordTableDefinition definition, int value)
        {
            definition.SetField("maxSerializedEntries", value);
            return definition;
        }

        public static RecordTableDefinition SetOffsetX(this RecordTableDefinition definition, float value)
        {
            definition.SetField("offsetX", value);
            return definition;
        }

        public static RecordTableDefinition SetOffsetY(this RecordTableDefinition definition, float value)
        {
            definition.SetField("offsetY", value);
            return definition;
        }

        public static RecordTableDefinition SetSpacing(this RecordTableDefinition definition, float value)
        {
            definition.SetField("spacing", value);
            return definition;
        }
    }
}