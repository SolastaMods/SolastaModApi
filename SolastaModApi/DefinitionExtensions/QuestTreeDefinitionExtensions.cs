using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class QuestTreeDefinitionExtensions
    {
        public static T SetSerializeVersion<T>(this T definition, int value)
            where T : QuestTreeDefinition
        {
            definition.SetField("serializeVersion", value);
            return definition;
        }
    }
}