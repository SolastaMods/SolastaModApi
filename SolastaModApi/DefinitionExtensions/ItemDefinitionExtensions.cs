using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class ItemDefinitionExtensions
    {
        public static T SetActiveTags<T>(this T definition, List<string> value)
            where T : ItemDefinition
        {
            definition.SetField("activeTags", value);
            return definition;
        }

        public static T SetAmmunitionDescription<T>(this T definition, AmmunitionDescription value)
            where T : ItemDefinition
        {
            definition.SetField("ammunitionDefinition", value);
            return definition;
        }

        public static T SetArmorDescription<T>(this T definition, ArmorDescription value)
            where T : ItemDefinition
        {
            definition.SetField("armorDefinition", value);
            return definition;
        }

        public static T SetContainerItemDescription<T>(this T definition, ContainerItemDescription value)
            where T : ItemDefinition
        {
            definition.SetField("containerItemDefinition", value);
            return definition;
        }

        public static T SetCosts<T>(this T definition, int[] value)
            where T : ItemDefinition
        {
            definition.SetField("costs", value);
            return definition;
        }

        public static T SetDefaultStackCount<T>(this T definition, int value)
            where T : ItemDefinition
        {
            definition.SetField("defaultStackCount", value);
            return definition;
        }

        public static T SetDocumentDescription<T>(this T definition, DocumentDescription value)
            where T : ItemDefinition
        {
            definition.SetField("documentDescription", value);
            return definition;
        }

        public static T SetFactionRelicDescription<T>(this T definition, FactionRelicDescription value)
            where T : ItemDefinition
        {
            definition.SetField("factionRelicDescription", value);
            return definition;
        }

        public static T SetFocusItemDescription<T>(this T definition, FocusItemDescription value)
            where T : ItemDefinition
        {
            definition.SetField("focusItemDefinition", value);
            return definition;
        }

        public static T SetFoodDescription<T>(this T definition, FoodDescription value)
            where T : ItemDefinition
        {
            definition.SetField("foodDescription", value);
            return definition;
        }

        public static T SetForceEquipSlot<T>(this T definition, string value)
            where T : ItemDefinition
        {
            definition.SetField("forceEquipSlot", value);
            return definition;
        }

        public static T SetInactiveTags<T>(this T definition, List<string> value)
            where T : ItemDefinition
        {
            definition.SetField("inactiveTags", value);
            return definition;
        }

        public static T SetItemPresentation<T>(this T definition, ItemPresentation value)
            where T : ItemDefinition
        {
            definition.SetField("itemPresentation", value);
            return definition;
        }

        public static T SetItemRarity<T>(this T definition, ItemRarity value)
            where T : ItemDefinition
        {
            definition.SetField("itemRarity", value);
            return definition;
        }

        public static T SetItemTags<T>(this T definition, List<string> value)
            where T : ItemDefinition
        {
            definition.SetField("itemTags", value);
            return definition;
        }

        public static T SetLightSourceItemDescription<T>(this T definition, LightSourceItemDescription value)
            where T : ItemDefinition
        {
            definition.SetField("lightSourceItemDefinition", value);
            return definition;
        }

        public static T SetMerchantCategory<T>(this T definition, string value)
            where T : ItemDefinition
        {
            definition.SetField("merchantCategory", value);
            return definition;
        }

        public static T SetPersonalityFlagOccurences<T>(this T definition, List<PersonalityFlagOccurence> value)
            where T : ItemDefinition
        {
            definition.SetField("personalityFlagOccurences", value);
            return definition;
        }

        public static T SetRequiredAttunementClasses<T>(this T definition, List<CharacterClassDefinition> value)
            where T : ItemDefinition
        {
            definition.SetField("requiredAttunementClasses", value);
            return definition;
        }

        public static T SetSlotsWhereActive<T>(this T definition, List<string> value)
            where T : ItemDefinition
        {
            definition.SetField("slotsWhereActive", value);
            return definition;
        }

        public static T SetSlotTypes<T>(this T definition, List<string> value)
            where T : ItemDefinition
        {
            definition.SetField("slotTypes", value);
            return definition;
        }

        public static T SetSoundEffectDescription<T>(this T definition, SoundEffectDescription value)
            where T : ItemDefinition
        {
            definition.SetField("soundEffectDescriptionOverride", value);
            return definition;
        }

        public static T SetSoundEffectOnHitDescription<T>(this T definition, SoundEffectOnHitDescription value)
            where T : ItemDefinition
        {
            definition.SetField("soundEffectOnHitDescriptionOverride", value);
            return definition;
        }

        public static T SetSpellbookDescription<T>(this T definition, SpellbookDescription value)
            where T : ItemDefinition
        {
            definition.SetField("spellbookDefinition", value);
            return definition;
        }

        public static T SetStackSize<T>(this T definition, int value)
            where T : ItemDefinition
        {
            definition.SetField("stackSize", value);
            return definition;
        }

        public static T SetStarterPackDescription<T>(this T definition, StarterPackDescription value)
            where T : ItemDefinition
        {
            definition.SetField("starterPackDefinition", value);
            return definition;
        }

        public static T SetStaticProperties<T>(this T definition, List<ItemPropertyDescription> value)
            where T : ItemDefinition
        {
            definition.SetField("staticProperties", value);
            return definition;
        }

        public static T SetToolDescription<T>(this T definition, ToolDescription value)
            where T : ItemDefinition
        {
            definition.SetField("toolDefinition", value);
            return definition;
        }

        public static T SetUsableDeviceDescription<T>(this T definition, UsableDeviceDescription value)
            where T : ItemDefinition
        {
            definition.SetField("usableDeviceDescription", value);
            return definition;
        }

        public static T SetWealthPileDescription<T>(this T definition, WealthPileDescription value)
            where T : ItemDefinition
        {
            definition.SetField("wealthPileDefinition", value);
            return definition;
        }

        public static T SetWeaponDescription<T>(this T definition, WeaponDescription value)
            where T : ItemDefinition
        {
            definition.SetField("weaponDefinition", value);
            return definition;
        }

        public static T SetWeight<T>(this T definition, float value)
            where T : ItemDefinition
        {
            definition.SetField("weight", value);
            return definition;
        }
    }
}