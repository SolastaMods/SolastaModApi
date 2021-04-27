using SolastaModApi.Infrastructure;
using static BanterDefinitions;

namespace SolastaModApi
{
    public static class CharacterBackgroundDefinitionExtensions
    {
        public static T SetBanterList<T>(this T definition, BanterList value)
            where T : CharacterBackgroundDefinition
        {
            definition.SetField("banterList", value);
            return definition;
        }

        public static T SetHasSubtype<T>(this T definition, bool value)
            where T : CharacterBackgroundDefinition
        {
            definition.SetField("hasSubtype", value);
            return definition;
        }

        public static T SetRequiresDeity<T>(this T definition, bool value)
            where T : CharacterBackgroundDefinition
        {
            definition.SetField("requiresDeity", value);
            return definition;
        }

        public static T SetSubTypeName<T>(this T definition, string value)
            where T : CharacterBackgroundDefinition
        {
            definition.SetField("subTypeName", value);
            return definition;
        }
    }
}