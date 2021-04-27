using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FormationDefinitionExtensions
    {
        public static T SetDefaultFormation<T>(this T definition, bool value)
            where T : FormationDefinition
        {
            definition.SetField("defaultFormation", value);
            return definition;
        }
    }
}