using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class DieStyleDefinitionExtensions
    {
        public static DieStyleDefinition SetD10MaterialReference(this DieStyleDefinition definition, AssetReference value)
        {
            definition.SetField("d10MaterialReference", value);
            return definition;
        }

        public static DieStyleDefinition SetD12MaterialReference(this DieStyleDefinition definition, AssetReference value)
        {
            definition.SetField("d12MaterialReference", value);
            return definition;
        }

        public static DieStyleDefinition SetD20MaterialReference(this DieStyleDefinition definition, AssetReference value)
        {
            definition.SetField("d20MaterialReference", value);
            return definition;
        }

        public static DieStyleDefinition SetD4MaterialReference(this DieStyleDefinition definition, AssetReference value)
        {
            definition.SetField("d4MaterialReference", value);
            return definition;
        }

        public static DieStyleDefinition SetD6MaterialReference(this DieStyleDefinition definition, AssetReference value)
        {
            definition.SetField("d6MaterialReference", value);
            return definition;
        }

        public static DieStyleDefinition SetD8MaterialReference(this DieStyleDefinition definition, AssetReference value)
        {
            definition.SetField("d8MaterialReference", value);
            return definition;
        }
    }
}