using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class QuestTreeDefinitionExtensions
    {
        public static T SetSerializeVersion<T>(this T entity, int value)
            where T : QuestTreeDefinition
        {
            entity.SetField("serializeVersion", value);
            return entity;
        }
    }
}