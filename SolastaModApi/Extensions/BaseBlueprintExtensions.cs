using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
    public static class BaseBlueprintExtensions
    {
        public static T SetCategory<T>(this T entity, string value)
            where T : BaseBlueprint
        {
            entity.SetField("category", value);
            return entity;
        }

        public static T SetDimensions<T>(this T entity, Vector2Int value)
            where T : BaseBlueprint
        {
            entity.SetField("dimensions", value);
            return entity;
        }
    }
}