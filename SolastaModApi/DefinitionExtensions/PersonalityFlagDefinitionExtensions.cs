using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class PersonalityFlagDefinitionExtensions
    {
        public static T SetDialog<T>(this T definition, bool value)
            where T : PersonalityFlagDefinition
        {
            definition.SetField("dialog", value);
            return definition;
        }

        public static T SetGameplay<T>(this T definition, bool value)
            where T : PersonalityFlagDefinition
        {
            definition.SetField("gameplay", value);
            return definition;
        }
    }
}