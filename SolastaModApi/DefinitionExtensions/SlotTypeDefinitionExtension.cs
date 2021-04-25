using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class SlotTypeDefinitionExtensions
    {
        public static void SetAlwaysLocked(this SlotTypeDefinition definition, Boolean value)
        {
            definition.SetField("alwaysLocked", value);
        }

        public static void SetBodySlot(this SlotTypeDefinition definition, Boolean value)
        {
            definition.SetField("bodySlot", value);
        }

        public static void SetCanDisplayArmor(this SlotTypeDefinition definition, Boolean value)
        {
            definition.SetField("canDisplayArmor", value);
        }

        public static void SetCanDisplayArmorForPhoto(this SlotTypeDefinition definition, Boolean value)
        {
            definition.SetField("canDisplayArmorForPhoto", value);
        }

        public static void SetCanDisplayLight(this SlotTypeDefinition definition, Boolean value)
        {
            definition.SetField("canDisplayLight", value);
        }

        public static void SetCanStack(this SlotTypeDefinition definition, Boolean value)
        {
            definition.SetField("canStack", value);
        }

        public static void SetDisplayArmorSortingIndex(this SlotTypeDefinition definition, Int32 value)
        {
            definition.SetField("displayArmorSortingIndex", value);
        }

        public static void SetHasDefaultVisual(this SlotTypeDefinition definition, Boolean value)
        {
            definition.SetField("hasDefaultVisual", value);
        }

        public static void SetLockedInBattle(this SlotTypeDefinition definition, Boolean value)
        {
            definition.SetField("lockedInBattle", value);
        }
    }
}