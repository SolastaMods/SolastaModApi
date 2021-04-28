using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class CharacterFamilyDefinitionExtensions
    {
        public static T SetExtraplanar<T>(this T entity, bool value)
            where T : CharacterFamilyDefinition
        {
            entity.SetField("extraplanar", value);
            return entity;
        }
    }
}