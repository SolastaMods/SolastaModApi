using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class KnowledgeLevelDefinitionExtensions
    {
        public static KnowledgeLevelDefinition SetAccessFlags(this KnowledgeLevelDefinition definition, int value)
        {
            definition.SetField("accessFlags", value);
            return definition;
        }

        public static KnowledgeLevelDefinition SetAdditionalDamage(this KnowledgeLevelDefinition definition, int value)
        {
            definition.SetField("additionalDamage", value);
            return definition;
        }

        public static KnowledgeLevelDefinition SetLevel(this KnowledgeLevelDefinition definition, int value)
        {
            definition.SetField("level", value);
            return definition;
        }
    }
}