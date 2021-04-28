using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class ItemDefinitionExtensions
    {
        public static T SetAmmunitionDescription<T>(this T entity, AmmunitionDescription value)
            where T : ItemDefinition
        {
            entity.SetField("ammunitionDefinition", value);
            return entity;
        }

        public static T SetArmorDescription<T>(this T entity, ArmorDescription value)
            where T : ItemDefinition
        {
            entity.SetField("armorDefinition", value);
            return entity;
        }

        public static T SetContainerItemDescription<T>(this T entity, ContainerItemDescription value)
            where T : ItemDefinition
        {
            entity.SetField("containerItemDefinition", value);
            return entity;
        }

        public static T SetCosts<T>(this T entity, int[] value)
            where T : ItemDefinition
        {
            entity.SetField("costs", value);
            return entity;
        }

        public static T SetDefaultStackCount<T>(this T entity, int value)
            where T : ItemDefinition
        {
            entity.SetField("defaultStackCount", value);
            return entity;
        }

        public static T SetDocumentDescription<T>(this T entity, DocumentDescription value)
            where T : ItemDefinition
        {
            entity.SetField("documentDescription", value);
            return entity;
        }

        public static T SetFactionRelicDescription<T>(this T entity, FactionRelicDescription value)
            where T : ItemDefinition
        {
            entity.SetField("factionRelicDescription", value);
            return entity;
        }

        public static T SetFocusItemDescription<T>(this T entity, FocusItemDescription value)
            where T : ItemDefinition
        {
            entity.SetField("focusItemDefinition", value);
            return entity;
        }

        public static T SetFoodDescription<T>(this T entity, FoodDescription value)
            where T : ItemDefinition
        {
            entity.SetField("foodDescription", value);
            return entity;
        }

        public static T SetForceEquipSlot<T>(this T entity, string value)
            where T : ItemDefinition
        {
            entity.SetField("forceEquipSlot", value);
            return entity;
        }

        public static T SetItemPresentation<T>(this T entity, ItemPresentation value)
            where T : ItemDefinition
        {
            entity.SetField("itemPresentation", value);
            return entity;
        }

        public static T SetItemRarity<T>(this T entity, ItemRarity value)
            where T : ItemDefinition
        {
            entity.SetField("itemRarity", value);
            return entity;
        }

        public static T SetLightSourceItemDescription<T>(this T entity, LightSourceItemDescription value)
            where T : ItemDefinition
        {
            entity.SetField("lightSourceItemDefinition", value);
            return entity;
        }

        public static T SetMerchantCategory<T>(this T entity, string value)
            where T : ItemDefinition
        {
            entity.SetField("merchantCategory", value);
            return entity;
        }

        public static T SetSoundEffectDescription<T>(this T entity, SoundEffectDescription value)
            where T : ItemDefinition
        {
            entity.SetField("soundEffectDescriptionOverride", value);
            return entity;
        }

        public static T SetSoundEffectOnHitDescription<T>(this T entity, SoundEffectOnHitDescription value)
            where T : ItemDefinition
        {
            entity.SetField("soundEffectOnHitDescriptionOverride", value);
            return entity;
        }

        public static T SetSpellbookDescription<T>(this T entity, SpellbookDescription value)
            where T : ItemDefinition
        {
            entity.SetField("spellbookDefinition", value);
            return entity;
        }

        public static T SetStackSize<T>(this T entity, int value)
            where T : ItemDefinition
        {
            entity.SetField("stackSize", value);
            return entity;
        }

        public static T SetStarterPackDescription<T>(this T entity, StarterPackDescription value)
            where T : ItemDefinition
        {
            entity.SetField("starterPackDefinition", value);
            return entity;
        }

        public static T SetToolDescription<T>(this T entity, ToolDescription value)
            where T : ItemDefinition
        {
            entity.SetField("toolDefinition", value);
            return entity;
        }

        public static T SetUsableDeviceDescription<T>(this T entity, UsableDeviceDescription value)
            where T : ItemDefinition
        {
            entity.SetField("usableDeviceDescription", value);
            return entity;
        }

        public static T SetWealthPileDescription<T>(this T entity, WealthPileDescription value)
            where T : ItemDefinition
        {
            entity.SetField("wealthPileDefinition", value);
            return entity;
        }

        public static T SetWeaponDescription<T>(this T entity, WeaponDescription value)
            where T : ItemDefinition
        {
            entity.SetField("weaponDefinition", value);
            return entity;
        }

        public static T SetWeight<T>(this T entity, float value)
            where T : ItemDefinition
        {
            entity.SetField("weight", value);
            return entity;
        }
    }
}