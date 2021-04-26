using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
    public static class RoomBlueprintExtensions
    {
        public static T SetCellInfos<T>(this T definition, int[] value)
            where T : RoomBlueprint
        {
            definition.SetField("cellInfos", value);
            return definition;
        }

        public static T SetEmbeddedGadgets<T>(this T definition, EmbeddedGadgetDescription[] value)
            where T : RoomBlueprint
        {
            definition.SetField("embeddedGadgets", value);
            return definition;
        }

        public static T SetEmbeddedProps<T>(this T definition, EmbeddedPropDescription[] value)
            where T : RoomBlueprint
        {
            definition.SetField("embeddedProps", value);
            return definition;
        }

        public static T SetGrounMaskSprite<T>(this T definition, Sprite value)
            where T : RoomBlueprint
        {
            definition.SetField("grounMaskSprite", value);
            return definition;
        }

        public static T SetWallAndOpeningSprite<T>(this T definition, Sprite value)
            where T : RoomBlueprint
        {
            definition.SetField("wallAndOpeningSprite", value);
            return definition;
        }

        public static T SetWallSprite<T>(this T definition, Sprite value)
            where T : RoomBlueprint
        {
            definition.SetField("wallSprite", value);
            return definition;
        }
    }
}