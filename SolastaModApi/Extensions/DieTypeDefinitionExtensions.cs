using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class DieTypeDefinitionExtensions
    {
        public static T SetDieType<T>(this T entity, DieType value)
            where T : DieTypeDefinition
        {
            entity.SetField("dieType", value);
            return entity;
        }

        public static T SetRollingMeshReference<T>(this T entity, AssetReference value)
            where T : DieTypeDefinition
        {
            entity.SetField("rollingMeshReference", value);
            return entity;
        }

        public static T SetScaleFactor<T>(this T entity, float value)
            where T : DieTypeDefinition
        {
            entity.SetField("scaleFactor", value);
            return entity;
        }
    }
}