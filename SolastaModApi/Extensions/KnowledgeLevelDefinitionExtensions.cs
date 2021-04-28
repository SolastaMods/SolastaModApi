using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class KnowledgeLevelDefinitionExtensions
    {
        public static T SetAccessFlags<T>(this T entity, int value)
            where T : KnowledgeLevelDefinition
        {
            entity.SetField("accessFlags", value);
            return entity;
        }

        public static T SetAdditionalDamage<T>(this T entity, int value)
            where T : KnowledgeLevelDefinition
        {
            entity.SetField("additionalDamage", value);
            return entity;
        }

        public static T SetLevel<T>(this T entity, int value)
            where T : KnowledgeLevelDefinition
        {
            entity.SetField("level", value);
            return entity;
        }
    }
}