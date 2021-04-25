using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ItemDefinitionExtensions
    {
        public static void SetActiveTags(this ItemDefinition definition, List<String> value)
        {
            definition.SetField("activeTags", value);
        }

        public static void SetAmmunitionDescription(this ItemDefinition definition, AmmunitionDescription value)
        {
            definition.SetField("ammunitionDefinition", value);
        }

        public static void SetArmorDescription(this ItemDefinition definition, ArmorDescription value)
        {
            definition.SetField("armorDefinition", value);
        }

        public static void SetContainerItemDescription(this ItemDefinition definition, ContainerItemDescription value)
        {
            definition.SetField("containerItemDefinition", value);
        }

        public static void SetCosts(this ItemDefinition definition, Int32[] value)
        {
            definition.SetField("costs", value);
        }

        public static void SetDefaultStackCount(this ItemDefinition definition, Int32 value)
        {
            definition.SetField("defaultStackCount", value);
        }

        public static void SetDocumentDescription(this ItemDefinition definition, DocumentDescription value)
        {
            definition.SetField("documentDescription", value);
        }

        public static void SetFactionRelicDescription(this ItemDefinition definition, FactionRelicDescription value)
        {
            definition.SetField("factionRelicDescription", value);
        }

        public static void SetFocusItemDescription(this ItemDefinition definition, FocusItemDescription value)
        {
            definition.SetField("focusItemDefinition", value);
        }

        public static void SetFoodDescription(this ItemDefinition definition, FoodDescription value)
        {
            definition.SetField("foodDescription", value);
        }

        public static void SetForceEquipSlot(this ItemDefinition definition, String value)
        {
            definition.SetField("forceEquipSlot", value);
        }

        public static void SetInactiveTags(this ItemDefinition definition, List<String> value)
        {
            definition.SetField("inactiveTags", value);
        }

        public static void SetItemPresentation(this ItemDefinition definition, ItemPresentation value)
        {
            definition.SetField("itemPresentation", value);
        }

        public static void SetItemRarity(this ItemDefinition definition, ItemRarity value)
        {
            definition.SetField("itemRarity", value);
        }

        public static void SetItemTags(this ItemDefinition definition, List<String> value)
        {
            definition.SetField("itemTags", value);
        }

        public static void SetLightSourceItemDescription(this ItemDefinition definition, LightSourceItemDescription value)
        {
            definition.SetField("lightSourceItemDefinition", value);
        }

        public static void SetMerchantCategory(this ItemDefinition definition, String value)
        {
            definition.SetField("merchantCategory", value);
        }

        public static void SetPersonalityFlagOccurences(this ItemDefinition definition, List<PersonalityFlagOccurence> value)
        {
            definition.SetField("personalityFlagOccurences", value);
        }

        public static void SetRequiredAttunementClasses(this ItemDefinition definition, List<CharacterClassDefinition> value)
        {
            definition.SetField("requiredAttunementClasses", value);
        }

        public static void SetSlotsWhereActive(this ItemDefinition definition, List<String> value)
        {
            definition.SetField("slotsWhereActive", value);
        }

        public static void SetSlotTypes(this ItemDefinition definition, List<String> value)
        {
            definition.SetField("slotTypes", value);
        }

        public static void SetSoundEffectDescription(this ItemDefinition definition, SoundEffectDescription value)
        {
            definition.SetField("soundEffectDescriptionOverride", value);
        }

        public static void SetSoundEffectOnHitDescription(this ItemDefinition definition, SoundEffectOnHitDescription value)
        {
            definition.SetField("soundEffectOnHitDescriptionOverride", value);
        }

        public static void SetSpellbookDescription(this ItemDefinition definition, SpellbookDescription value)
        {
            definition.SetField("spellbookDefinition", value);
        }

        public static void SetStackSize(this ItemDefinition definition, Int32 value)
        {
            definition.SetField("stackSize", value);
        }

        public static void SetStarterPackDescription(this ItemDefinition definition, StarterPackDescription value)
        {
            definition.SetField("starterPackDefinition", value);
        }

        public static void SetStaticProperties(this ItemDefinition definition, List<ItemPropertyDescription> value)
        {
            definition.SetField("staticProperties", value);
        }

        public static void SetToolDescription(this ItemDefinition definition, ToolDescription value)
        {
            definition.SetField("toolDefinition", value);
        }

        public static void SetUsableDeviceDescription(this ItemDefinition definition, UsableDeviceDescription value)
        {
            definition.SetField("usableDeviceDescription", value);
        }

        public static void SetWealthPileDescription(this ItemDefinition definition, WealthPileDescription value)
        {
            definition.SetField("wealthPileDefinition", value);
        }

        public static void SetWeaponDescription(this ItemDefinition definition, WeaponDescription value)
        {
            definition.SetField("weaponDefinition", value);
        }

        public static void SetWeight(this ItemDefinition definition, Single value)
        {
            definition.SetField("weight", value);
        }
    }
}