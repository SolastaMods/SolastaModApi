using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class CharacterFamilyDefinitionExtensions
    {
        public static T SetExtraplanar<T>(this T definition, bool value)
            where T : CharacterFamilyDefinition
        {
            definition.SetField("extraplanar", value);
            return definition;
        }
    }
}