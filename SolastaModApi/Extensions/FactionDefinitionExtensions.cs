using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    public static class FactionDefinitionExtensions
    {
        public static T SetBuiltIn<T>(this T entity, bool value)
            where T : FactionDefinition
        {
            entity.SetField("builtIn", value);
            return entity;
        }

        public static T SetMaxRelationCap<T>(this T entity, int value)
            where T : FactionDefinition
        {
            entity.SetField("maxRelationCap", value);
            return entity;
        }

        public static T SetMinRelationCap<T>(this T entity, int value)
            where T : FactionDefinition
        {
            entity.SetField("minRelationCap", value);
            return entity;
        }

        public static T SetSmallSpriteReference<T>(this T entity, AssetReferenceSprite value)
            where T : FactionDefinition
        {
            entity.SetField("smallSpriteReference", value);
            return entity;
        }
    }
}