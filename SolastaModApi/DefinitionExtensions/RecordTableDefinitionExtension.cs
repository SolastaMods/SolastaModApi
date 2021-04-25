using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class RecordTableDefinitionExtensions
    {
        public static void SetAreaWidth(this RecordTableDefinition definition, Single value)
        {
            definition.SetField("areaWidth", value);
        }

        public static void SetLayout(this RecordTableDefinition definition, RecordTableDefinition.LayoutType value)
        {
            definition.SetField("layout", value);
        }

        public static void SetMaxEntries(this RecordTableDefinition definition, Int32 value)
        {
            definition.SetField("maxEntries", value);
        }

        public static void SetMaxSerializedEntries(this RecordTableDefinition definition, Int32 value)
        {
            definition.SetField("maxSerializedEntries", value);
        }

        public static void SetOffsetX(this RecordTableDefinition definition, Single value)
        {
            definition.SetField("offsetX", value);
        }

        public static void SetOffsetY(this RecordTableDefinition definition, Single value)
        {
            definition.SetField("offsetY", value);
        }

        public static void SetSpacing(this RecordTableDefinition definition, Single value)
        {
            definition.SetField("spacing", value);
        }
    }
}