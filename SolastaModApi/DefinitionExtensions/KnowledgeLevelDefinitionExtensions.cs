using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class KnowledgeLevelDefinitionExtensions
    {
        public static T SetAccessFlags<T>(this T definition, int value)
            where T : KnowledgeLevelDefinition
        {
            definition.SetField("accessFlags", value);
            return definition;
        }

        public static T SetAdditionalDamage<T>(this T definition, int value)
            where T : KnowledgeLevelDefinition
        {
            definition.SetField("additionalDamage", value);
            return definition;
        }

        public static T SetLevel<T>(this T definition, int value)
            where T : KnowledgeLevelDefinition
        {
            definition.SetField("level", value);
            return definition;
        }
    }
}