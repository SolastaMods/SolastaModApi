using SolastaModApi.Infrastructure;
using static BanterDefinitions;

namespace SolastaModApi
{
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