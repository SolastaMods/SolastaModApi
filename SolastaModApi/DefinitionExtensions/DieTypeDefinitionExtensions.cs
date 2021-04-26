using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class DieTypeDefinitionExtensions
    {
        public static T SetDieType<T>(this T definition, DieType value)
            where T : DieTypeDefinition
        {
            definition.SetField("dieType", value);
            return definition;
        }

        public static T SetRollingMeshReference<T>(this T definition, AssetReference value)
            where T : DieTypeDefinition
        {
            definition.SetField("rollingMeshReference", value);
            return definition;
        }

        public static T SetScaleFactor<T>(this T definition, float value)
            where T : DieTypeDefinition
        {
            definition.SetField("scaleFactor", value);
            return definition;
        }
    }
}