using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
    public static class RoomBlueprintExtensions
    {
        public static T SetCellInfos<T>(this T entity, int[] value)
            where T : RoomBlueprint
        {
            entity.SetField("cellInfos", value);
            return entity;
        }

        public static T SetEmbeddedGadgets<T>(this T entity, EmbeddedGadgetDescription[] value)
            where T : RoomBlueprint
        {
            entity.SetField("embeddedGadgets", value);
            return entity;
        }

        public static T SetEmbeddedProps<T>(this T entity, EmbeddedPropDescription[] value)
            where T : RoomBlueprint
        {
            entity.SetField("embeddedProps", value);
            return entity;
        }

        public static T SetGrounMaskSprite<T>(this T entity, Sprite value)
            where T : RoomBlueprint
        {
            entity.SetField("grounMaskSprite", value);
            return entity;
        }

        public static T SetWallAndOpeningSprite<T>(this T entity, Sprite value)
            where T : RoomBlueprint
        {
            entity.SetField("wallAndOpeningSprite", value);
            return entity;
        }

        public static T SetWallSprite<T>(this T entity, Sprite value)
            where T : RoomBlueprint
        {
            entity.SetField("wallSprite", value);
            return entity;
        }
    }
}