using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class KnowledgeLevelDefinitionExtensions
    {
        public static void SetAccessFlags(this KnowledgeLevelDefinition definition, Int32 value)
        {
            definition.SetField("accessFlags", value);
        }

        public static void SetAdditionalDamage(this KnowledgeLevelDefinition definition, Int32 value)
        {
            definition.SetField("additionalDamage", value);
        }

        public static void SetLevel(this KnowledgeLevelDefinition definition, Int32 value)
        {
            definition.SetField("level", value);
        }
    }
}