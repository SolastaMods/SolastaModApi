using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DieStyleDefinitionExtensions
    {
        public static void SetD10MaterialReference(this DieStyleDefinition definition, AssetReference value)
        {
            definition.SetField("d10MaterialReference", value);
        }

        public static void SetD12MaterialReference(this DieStyleDefinition definition, AssetReference value)
        {
            definition.SetField("d12MaterialReference", value);
        }

        public static void SetD20MaterialReference(this DieStyleDefinition definition, AssetReference value)
        {
            definition.SetField("d20MaterialReference", value);
        }

        public static void SetD4MaterialReference(this DieStyleDefinition definition, AssetReference value)
        {
            definition.SetField("d4MaterialReference", value);
        }

        public static void SetD6MaterialReference(this DieStyleDefinition definition, AssetReference value)
        {
            definition.SetField("d6MaterialReference", value);
        }

        public static void SetD8MaterialReference(this DieStyleDefinition definition, AssetReference value)
        {
            definition.SetField("d8MaterialReference", value);
        }
    }
}