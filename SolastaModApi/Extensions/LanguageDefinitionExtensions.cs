using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class LanguageDefinitionExtensions
    {
        public static T SetPersonalityAdditiveBase<T>(this T entity, int value)
            where T : LanguageDefinition
        {
            entity.SetField("personalityAdditiveBase", value);
            return entity;
        }

        public static T SetPersonalityFlag<T>(this T entity, bool value)
            where T : LanguageDefinition
        {
            entity.SetField("personalityFlag", value);
            return entity;
        }
    }
}