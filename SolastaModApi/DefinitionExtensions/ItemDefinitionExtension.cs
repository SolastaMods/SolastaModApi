using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ItemDefinitionExtensions
    {
        public static ItemDefinition SetActiveTags(this ItemDefinition definition, List<string> value)
        {
            definition.SetField("activeTags", value);
            return definition;
        }

        public static ItemDefinition SetAmmunitionDescription(this ItemDefinition definition, AmmunitionDescription value)
        {
            definition.SetField("ammunitionDefinition", value);
            return definition;
        }

        public static ItemDefinition SetArmorDescription(this ItemDefinition definition, ArmorDescription value)
        {
            definition.SetField("armorDefinition", value);
            return definition;
        }

        public static ItemDefinition SetContainerItemDescription(this ItemDefinition definition, ContainerItemDescription value)
        {
            definition.SetField("containerItemDefinition", value);
            return definition;
        }

        public static ItemDefinition SetCosts(this ItemDefinition definition, int[] value)
        {
            definition.SetField("costs", value);
            return definition;
        }

        public static ItemDefinition SetDefaultStackCount(this ItemDefinition definition, int value)
        {
            definition.SetField("defaultStackCount", value);
            return definition;
        }

        public static ItemDefinition SetDocumentDescription(this ItemDefinition definition, DocumentDescription value)
        {
            definition.SetField("documentDescription", value);
            return definition;
        }

        public static ItemDefinition SetFactionRelicDescription(this ItemDefinition definition, FactionRelicDescription value)
        {
            definition.SetField("factionRelicDescription", value);
            return definition;
        }

        public static ItemDefinition SetFocusItemDescription(this ItemDefinition definition, FocusItemDescription value)
        {
            definition.SetField("focusItemDefinition", value);
            return definition;
        }

        public static ItemDefinition SetFoodDescription(this ItemDefinition definition, FoodDescription value)
        {
            definition.SetField("foodDescription", value);
            return definition;
        }

        public static ItemDefinition SetForceEquipSlot(this ItemDefinition definition, string value)
        {
            definition.SetField("forceEquipSlot", value);
            return definition;
        }

        public static ItemDefinition SetInactiveTags(this ItemDefinition definition, List<string> value)
        {
            definition.SetField("inactiveTags", value);
            return definition;
        }

        public static ItemDefinition SetItemPresentation(this ItemDefinition definition, ItemPresentation value)
        {
            definition.SetField("itemPresentation", value);
            return definition;
        }

        public static ItemDefinition SetItemRarity(this ItemDefinition definition, ItemRarity value)
        {
            definition.SetField("itemRarity", value);
            return definition;
        }

        public static ItemDefinition SetItemTags(this ItemDefinition definition, List<string> value)
        {
            definition.SetField("itemTags", value);
            return definition;
        }

        public static ItemDefinition SetLightSourceItemDescription(this ItemDefinition definition, LightSourceItemDescription value)
        {
            definition.SetField("lightSourceItemDefinition", value);
            return definition;
        }

        public static ItemDefinition SetMerchantCategory(this ItemDefinition definition, string value)
        {
            definition.SetField("merchantCategory", value);
            return definition;
        }

        public static ItemDefinition SetPersonalityFlagOccurences(this ItemDefinition definition, List<PersonalityFlagOccurence> value)
        {
            definition.SetField("personalityFlagOccurences", value);
            return definition;
        }

        public static ItemDefinition SetRequiredAttunementClasses(this ItemDefinition definition, List<CharacterClassDefinition> value)
        {
            definition.SetField("requiredAttunementClasses", value);
            return definition;
        }

        public static ItemDefinition SetSlotsWhereActive(this ItemDefinition definition, List<string> value)
        {
            definition.SetField("slotsWhereActive", value);
            return definition;
        }

        public static ItemDefinition SetSlotTypes(this ItemDefinition definition, List<string> value)
        {
            definition.SetField("slotTypes", value);
            return definition;
        }

        public static ItemDefinition SetSoundEffectDescription(this ItemDefinition definition, SoundEffectDescription value)
        {
            definition.SetField("soundEffectDescriptionOverride", value);
            return definition;
        }

        public static ItemDefinition SetSoundEffectOnHitDescription(this ItemDefinition definition, SoundEffectOnHitDescription value)
        {
            definition.SetField("soundEffectOnHitDescriptionOverride", value);
            return definition;
        }

        public static ItemDefinition SetSpellbookDescription(this ItemDefinition definition, SpellbookDescription value)
        {
            definition.SetField("spellbookDefinition", value);
            return definition;
        }

        public static ItemDefinition SetStackSize(this ItemDefinition definition, int value)
        {
            definition.SetField("stackSize", value);
            return definition;
        }

        public static ItemDefinition SetStarterPackDescription(this ItemDefinition definition, StarterPackDescription value)
        {
            definition.SetField("starterPackDefinition", value);
            return definition;
        }

        public static ItemDefinition SetStaticProperties(this ItemDefinition definition, List<ItemPropertyDescription> value)
        {
            definition.SetField("staticProperties", value);
            return definition;
        }

        public static ItemDefinition SetToolDescription(this ItemDefinition definition, ToolDescription value)
        {
            definition.SetField("toolDefinition", value);
            return definition;
        }

        public static ItemDefinition SetUsableDeviceDescription(this ItemDefinition definition, UsableDeviceDescription value)
        {
            definition.SetField("usableDeviceDescription", value);
            return definition;
        }

        public static ItemDefinition SetWealthPileDescription(this ItemDefinition definition, WealthPileDescription value)
        {
            definition.SetField("wealthPileDefinition", value);
            return definition;
        }

        public static ItemDefinition SetWeaponDescription(this ItemDefinition definition, WeaponDescription value)
        {
            definition.SetField("weaponDefinition", value);
            return definition;
        }

        public static ItemDefinition SetWeight(this ItemDefinition definition, float value)
        {
            definition.SetField("weight", value);
            return definition;
        }
    }
}