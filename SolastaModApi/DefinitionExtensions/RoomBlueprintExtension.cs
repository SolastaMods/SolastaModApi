using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class RoomBlueprintExtensions
    {
        public static RoomBlueprint SetCellInfos(this RoomBlueprint definition, int[] value)
        {
            definition.SetField("cellInfos", value);
            return definition;
        }

        public static RoomBlueprint SetEmbeddedGadgets(this RoomBlueprint definition, EmbeddedGadgetDescription[] value)
        {
            definition.SetField("embeddedGadgets", value);
            return definition;
        }

        public static RoomBlueprint SetEmbeddedProps(this RoomBlueprint definition, EmbeddedPropDescription[] value)
        {
            definition.SetField("embeddedProps", value);
            return definition;
        }

        public static RoomBlueprint SetGrounMaskSprite(this RoomBlueprint definition, Sprite value)
        {
            definition.SetField("grounMaskSprite", value);
            return definition;
        }

        public static RoomBlueprint SetWallAndOpeningSprite(this RoomBlueprint definition, Sprite value)
        {
            definition.SetField("wallAndOpeningSprite", value);
            return definition;
        }

        public static RoomBlueprint SetWallSprite(this RoomBlueprint definition, Sprite value)
        {
            definition.SetField("wallSprite", value);
            return definition;
        }
    }
}