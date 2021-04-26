using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class LanguageDefinitionExtensions
    {
        public static T SetPersonalityAdditiveBase<T>(this T definition, int value)
            where T : LanguageDefinition
        {
            definition.SetField("personalityAdditiveBase", value);
            return definition;
        }

        public static T SetPersonalityFlag<T>(this T definition, bool value)
            where T : LanguageDefinition
        {
            definition.SetField("personalityFlag", value);
            return definition;
        }
    }
}