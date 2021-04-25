using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class PersonalityFlagDefinitionExtensions
    {
        public static PersonalityFlagDefinition SetDialog(this PersonalityFlagDefinition definition, bool value)
        {
            definition.SetField("dialog", value);
            return definition;
        }

        public static PersonalityFlagDefinition SetGameplay(this PersonalityFlagDefinition definition, bool value)
        {
            definition.SetField("gameplay", value);
            return definition;
        }
    }
}