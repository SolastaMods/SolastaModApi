using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class SlotTypeDefinitionExtensions
    {
        public static T SetAlwaysLocked<T>(this T entity, bool value)
            where T : SlotTypeDefinition
        {
            entity.SetField("alwaysLocked", value);
            return entity;
        }

        public static T SetBodySlot<T>(this T entity, bool value)
            where T : SlotTypeDefinition
        {
            entity.SetField("bodySlot", value);
            return entity;
        }

        public static T SetCanDisplayArmor<T>(this T entity, bool value)
            where T : SlotTypeDefinition
        {
            entity.SetField("canDisplayArmor", value);
            return entity;
        }

        public static T SetCanDisplayArmorForPhoto<T>(this T entity, bool value)
            where T : SlotTypeDefinition
        {
            entity.SetField("canDisplayArmorForPhoto", value);
            return entity;
        }

        public static T SetCanDisplayLight<T>(this T entity, bool value)
            where T : SlotTypeDefinition
        {
            entity.SetField("canDisplayLight", value);
            return entity;
        }

        public static T SetCanStack<T>(this T entity, bool value)
            where T : SlotTypeDefinition
        {
            entity.SetField("canStack", value);
            return entity;
        }

        public static T SetDisplayArmorSortingIndex<T>(this T entity, int value)
            where T : SlotTypeDefinition
        {
            entity.SetField("displayArmorSortingIndex", value);
            return entity;
        }

        public static T SetHasDefaultVisual<T>(this T entity, bool value)
            where T : SlotTypeDefinition
        {
            entity.SetField("hasDefaultVisual", value);
            return entity;
        }

        public static T SetLockedInBattle<T>(this T entity, bool value)
            where T : SlotTypeDefinition
        {
            entity.SetField("lockedInBattle", value);
            return entity;
        }
    }
}