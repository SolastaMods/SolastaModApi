using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class SlotTypeDefinitionExtensions
    {
        public static T SetAlwaysLocked<T>(this T definition, bool value)
            where T : SlotTypeDefinition
        {
            definition.SetField("alwaysLocked", value);
            return definition;
        }

        public static T SetBodySlot<T>(this T definition, bool value)
            where T : SlotTypeDefinition
        {
            definition.SetField("bodySlot", value);
            return definition;
        }

        public static T SetCanDisplayArmor<T>(this T definition, bool value)
            where T : SlotTypeDefinition
        {
            definition.SetField("canDisplayArmor", value);
            return definition;
        }

        public static T SetCanDisplayArmorForPhoto<T>(this T definition, bool value)
            where T : SlotTypeDefinition
        {
            definition.SetField("canDisplayArmorForPhoto", value);
            return definition;
        }

        public static T SetCanDisplayLight<T>(this T definition, bool value)
            where T : SlotTypeDefinition
        {
            definition.SetField("canDisplayLight", value);
            return definition;
        }

        public static T SetCanStack<T>(this T definition, bool value)
            where T : SlotTypeDefinition
        {
            definition.SetField("canStack", value);
            return definition;
        }

        public static T SetDisplayArmorSortingIndex<T>(this T definition, int value)
            where T : SlotTypeDefinition
        {
            definition.SetField("displayArmorSortingIndex", value);
            return definition;
        }

        public static T SetHasDefaultVisual<T>(this T definition, bool value)
            where T : SlotTypeDefinition
        {
            definition.SetField("hasDefaultVisual", value);
            return definition;
        }

        public static T SetLockedInBattle<T>(this T definition, bool value)
            where T : SlotTypeDefinition
        {
            definition.SetField("lockedInBattle", value);
            return definition;
        }
    }
}