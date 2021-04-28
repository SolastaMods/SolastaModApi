using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class GuiEquipmentItemExtensions
    {
        public static T SetCompareason<T>(this T entity, bool value)
            where T : GuiEquipmentItem
        {
            entity.SetField("compareason", value);
            return entity;
        }

        public static T SetEquipmentItem<T>(this T entity, RulesetItem value)
            where T : GuiEquipmentItem
        {
            entity.SetField("equipmentItem", value);
            return entity;
        }

        public static T SetGuiItemDefinition<T>(this T entity, GuiItemDefinition value)
            where T : GuiEquipmentItem
        {
            entity.SetField("guiItemDefinition", value);
            return entity;
        }

        public static T SetInventorySlot<T>(this T entity, RulesetInventorySlot value)
            where T : GuiEquipmentItem
        {
            entity.SetField("inventorySlot", value);
            return entity;
        }
    }
}