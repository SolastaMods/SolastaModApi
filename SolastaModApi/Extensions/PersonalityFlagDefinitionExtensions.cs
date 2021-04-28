using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class PersonalityFlagDefinitionExtensions
    {
        public static T SetDialog<T>(this T entity, bool value)
            where T : PersonalityFlagDefinition
        {
            entity.SetField("dialog", value);
            return entity;
        }

        public static T SetGameplay<T>(this T entity, bool value)
            where T : PersonalityFlagDefinition
        {
            entity.SetField("gameplay", value);
            return entity;
        }
    }
}