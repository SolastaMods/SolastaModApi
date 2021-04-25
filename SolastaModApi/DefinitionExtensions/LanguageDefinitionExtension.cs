using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class LanguageDefinitionExtensions
    {
        public static LanguageDefinition SetPersonalityAdditiveBase(this LanguageDefinition definition, int value)
        {
            definition.SetField("personalityAdditiveBase", value);
            return definition;
        }

        public static LanguageDefinition SetPersonalityFlag(this LanguageDefinition definition, bool value)
        {
            definition.SetField("personalityFlag", value);
            return definition;
        }
    }
}