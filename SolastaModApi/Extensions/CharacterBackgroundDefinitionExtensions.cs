using SolastaModApi.Infrastructure;
using static BanterDefinitions;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class CharacterBackgroundDefinitionExtensions
    {
        public static T SetBanterList<T>(this T entity, BanterList value)
            where T : CharacterBackgroundDefinition
        {
            entity.SetField("banterList", value);
            return entity;
        }

        public static T SetHasSubtype<T>(this T entity, bool value)
            where T : CharacterBackgroundDefinition
        {
            entity.SetField("hasSubtype", value);
            return entity;
        }

        public static T SetRequiresDeity<T>(this T entity, bool value)
            where T : CharacterBackgroundDefinition
        {
            entity.SetField("requiresDeity", value);
            return entity;
        }

        public static T SetSubTypeName<T>(this T entity, string value)
            where T : CharacterBackgroundDefinition
        {
            entity.SetField("subTypeName", value);
            return entity;
        }
    }
}