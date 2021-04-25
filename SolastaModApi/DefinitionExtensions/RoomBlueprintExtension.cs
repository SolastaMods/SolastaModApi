using SolastaModApi.Infrastructure;
using UnityEngine;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class RoomBlueprintExtensions
    {
        public static void SetCellInfos(this RoomBlueprint definition, Int32[] value)
        {
            definition.SetField("cellInfos", value);
        }

        public static void SetEmbeddedGadgets(this RoomBlueprint definition, EmbeddedGadgetDescription[] value)
        {
            definition.SetField("embeddedGadgets", value);
        }

        public static void SetEmbeddedProps(this RoomBlueprint definition, EmbeddedPropDescription[] value)
        {
            definition.SetField("embeddedProps", value);
        }

        public static void SetGrounMaskSprite(this RoomBlueprint definition, Sprite value)
        {
            definition.SetField("grounMaskSprite", value);
        }

        public static void SetWallAndOpeningSprite(this RoomBlueprint definition, Sprite value)
        {
            definition.SetField("wallAndOpeningSprite", value);
        }

        public static void SetWallSprite(this RoomBlueprint definition, Sprite value)
        {
            definition.SetField("wallSprite", value);
        }
    }
}