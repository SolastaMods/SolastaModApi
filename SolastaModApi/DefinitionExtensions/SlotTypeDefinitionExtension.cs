using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class SlotTypeDefinitionExtensions
    {
        public static SlotTypeDefinition SetAlwaysLocked(this SlotTypeDefinition definition, bool value)
        {
            definition.SetField("alwaysLocked", value);
            return definition;
        }

        public static SlotTypeDefinition SetBodySlot(this SlotTypeDefinition definition, bool value)
        {
            definition.SetField("bodySlot", value);
            return definition;
        }

        public static SlotTypeDefinition SetCanDisplayArmor(this SlotTypeDefinition definition, bool value)
        {
            definition.SetField("canDisplayArmor", value);
            return definition;
        }

        public static SlotTypeDefinition SetCanDisplayArmorForPhoto(this SlotTypeDefinition definition, bool value)
        {
            definition.SetField("canDisplayArmorForPhoto", value);
            return definition;
        }

        public static SlotTypeDefinition SetCanDisplayLight(this SlotTypeDefinition definition, bool value)
        {
            definition.SetField("canDisplayLight", value);
            return definition;
        }

        public static SlotTypeDefinition SetCanStack(this SlotTypeDefinition definition, bool value)
        {
            definition.SetField("canStack", value);
            return definition;
        }

        public static SlotTypeDefinition SetDisplayArmorSortingIndex(this SlotTypeDefinition definition, int value)
        {
            definition.SetField("displayArmorSortingIndex", value);
            return definition;
        }

        public static SlotTypeDefinition SetHasDefaultVisual(this SlotTypeDefinition definition, bool value)
        {
            definition.SetField("hasDefaultVisual", value);
            return definition;
        }

        public static SlotTypeDefinition SetLockedInBattle(this SlotTypeDefinition definition, bool value)
        {
            definition.SetField("lockedInBattle", value);
            return definition;
        }
    }
}