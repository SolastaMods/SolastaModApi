using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    public static class DieStyleDefinitionExtensions
    {
        public static T SetD10MaterialReference<T>(this T definition, AssetReference value)
            where T : DieStyleDefinition
        {
            definition.SetField("d10MaterialReference", value);
            return definition;
        }

        public static T SetD12MaterialReference<T>(this T definition, AssetReference value)
            where T : DieStyleDefinition
        {
            definition.SetField("d12MaterialReference", value);
            return definition;
        }

        public static T SetD20MaterialReference<T>(this T definition, AssetReference value)
            where T : DieStyleDefinition
        {
            definition.SetField("d20MaterialReference", value);
            return definition;
        }

        public static T SetD4MaterialReference<T>(this T definition, AssetReference value)
            where T : DieStyleDefinition
        {
            definition.SetField("d4MaterialReference", value);
            return definition;
        }

        public static T SetD6MaterialReference<T>(this T definition, AssetReference value)
            where T : DieStyleDefinition
        {
            definition.SetField("d6MaterialReference", value);
            return definition;
        }

        public static T SetD8MaterialReference<T>(this T definition, AssetReference value)
            where T : DieStyleDefinition
        {
            definition.SetField("d8MaterialReference", value);
            return definition;
        }
    }
}