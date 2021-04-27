
using HarmonyLib;
using TA.AI;
using UnityEngine;
using UnityEngine.AddressableAssets;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using static ItemDefinition;

namespace SolastaModApi
{
    public class ItemDefinitionBuilder
    {
        ItemDefinition MyItem;

        public ItemDefinitionBuilder()
        {
            MyItem = ScriptableObject.CreateInstance<ItemDefinition>();
        }

        public void SetInDungeonEditor(bool inDungeonEditor)
        {
            Traverse.Create(MyItem).Field("inDungeonEditor").SetValue(inDungeonEditor);
        }

        public void SetMerchantCategory(string merchantCategory)
        {
            Traverse.Create(MyItem).Field("merchantCategory").SetValue(merchantCategory);
        }

        public void SetWeight(float weight)
        {
            //float weightf = (float)weight;
            Traverse.Create(MyItem).Field("weight").SetValue(weight);
        }

        public void AddSlotTypes(SlotTypeDefinition slotTypes)
        {
            MyItem.SlotTypes.Add(slotTypes.Name);
        }

        public void AddSlotsWhereActive(SlotTypeDefinition slotsWhereActive)
        {
            MyItem.SlotsWhereActive.Add(slotsWhereActive.Name);
        }

        public void SetActiveOnGround(bool activeOnGround)
        {
            Traverse.Create(MyItem).Field("activeOnGround").SetValue(activeOnGround);
        }

        public void SetForceEquip(bool forceEquip)
        {
            Traverse.Create(MyItem).Field("forceEquip").SetValue(forceEquip);
        }

        public void SetForceEquipSlot(string forceEquipSlot)
        {
            Traverse.Create(MyItem).Field("forceEquipSlot").SetValue(forceEquipSlot);
        }

        public void SetCanBeStacked(bool canBeStacked)
        {
            Traverse.Create(MyItem).Field("canBeStacked").SetValue(canBeStacked);
        }

        public void SetStackSize(int stackSize)
        {
            Traverse.Create(MyItem).Field("stackSize").SetValue(stackSize);
        }

        public void SetDefaultStackCount(int defaultStackCount)
        {
            Traverse.Create(MyItem).Field("defaultStackCount").SetValue(defaultStackCount);
        }

        // Array has 5 elements limit. Don't put more than 5 elements. 
        public void AddCosts(IEnumerable<int> costList)
        {
            if (costList.Count() != 5) { throw new ArgumentException("Please supply exactly 5 costs"); }
            Traverse.Create(MyItem).Field("costs").SetValue(costList.ToArray());
        }

        // Another way to add an int array field to builder, add as list and convert to array
        //public void addcosts(List<int> costlist)
        //{
        //    foreach (int cost in costlist)
        //    {
        //        costlist.Add(cost);
        //    }
        //    costlist.ToArray().CopyTo(MyItem.Costs, 0);
        //}

        public void AddItemTags(string itemTags)
        {
            MyItem.ItemTags.Add(itemTags);
        }

        public void AddActiveTags(string activeTags)
        {
            MyItem.ActiveTags.Add(activeTags);
        }

        public void AddInactiveTags(string inactiveTags)
        {
            MyItem.InactiveTags.Add(inactiveTags);
        }

        public void SetMagical(bool magical)
        {
            Traverse.Create(MyItem).Field("magical").SetValue(magical);
        }

        public void SetRequiresAttunement(bool requiresAttunement)
        {
            Traverse.Create(MyItem).Field("requiresAttunement").SetValue(requiresAttunement);
        }

        public void SetRequiresIdentification(bool requiresIdentification)
        {
            Traverse.Create(MyItem).Field("requiresIdentification").SetValue(requiresIdentification);
        }

        public void AddRequiredAttunementClasses(CharacterClassDefinition requiredAttunementClasses)
        {
            MyItem.RequiredAttunementClasses.Add(requiredAttunementClasses);
        }

        public void SetItemRarity(RuleDefinitions.ItemRarity itemRarity)
        {
            Traverse.Create(MyItem).Field("itemRarity").SetValue(itemRarity);
        }

        public void AddStaticPropertiesFeature(bool appliesOnItemOnly, ItemPropertyDescription.PropertyType type, FeatureDefinition featureDefinition, EquipmentDefinitions.KnowledgeAffinity knowledgeAffinity)
        {
            ItemPropertyDescription staticPropertiesFeature = new ItemPropertyDescription();
            Traverse.Create(staticPropertiesFeature).Field("appliesOnItemOnly").SetValue(appliesOnItemOnly);
            Traverse.Create(staticPropertiesFeature).Field("type").SetValue(type);
            Traverse.Create(staticPropertiesFeature).Field("featureDefinition").SetValue(featureDefinition);
            Traverse.Create(staticPropertiesFeature).Field("knowledgeAffinity").SetValue(knowledgeAffinity);
            MyItem.StaticProperties.Add(staticPropertiesFeature);
        }

        public void AddStaticPropertiesCondition(bool appliesOnItemOnly, ItemPropertyDescription.PropertyType type, ConditionDefinition conditionDefinition, EquipmentDefinitions.KnowledgeAffinity knowledgeAffinity)
        {
            ItemPropertyDescription staticPropertiesCondition = new ItemPropertyDescription();
            Traverse.Create(staticPropertiesCondition).Field("appliesOnItemOnly").SetValue(appliesOnItemOnly);
            Traverse.Create(staticPropertiesCondition).Field("type").SetValue(type);
            Traverse.Create(staticPropertiesCondition).Field("conditionDefinition").SetValue(conditionDefinition);
            Traverse.Create(staticPropertiesCondition).Field("knowledgeAffinity").SetValue(knowledgeAffinity);
            MyItem.StaticProperties.Add(staticPropertiesCondition);
        }

        public void SetIsArmor(bool isArmor)
        {
            Traverse.Create(MyItem).Field("isArmor").SetValue(isArmor);
        }

        public void SetArmorDefinition(ArmorTypeDefinition armorType, int armorClassValue, bool isBaseArmorClass, int maxDexterityBonus, bool requiresMinimalStrength, int minimalStrength)
        {
            ArmorDescription armorDefinition = new ArmorDescription();
            Traverse.Create(armorDefinition).Field("armorType").SetValue(armorType.Name);
            Traverse.Create(armorDefinition).Field("armorClassValue").SetValue(armorClassValue);
            Traverse.Create(armorDefinition).Field("isBaseArmorClass").SetValue(isBaseArmorClass);
            Traverse.Create(armorDefinition).Field("maxDexterityBonus").SetValue(maxDexterityBonus);
            Traverse.Create(armorDefinition).Field("requiresMinimalStrength").SetValue(requiresMinimalStrength);
            Traverse.Create(armorDefinition).Field("minimalStrength").SetValue(minimalStrength);
            Traverse.Create(MyItem).Field("armorDefinition").SetValue(armorDefinition);
        }

        public void SetIsWeapon(bool isWeapon)
        {
            Traverse.Create(MyItem).Field("isWeapon").SetValue(isWeapon);
        }

        // Weapon Definition requires Effect Description
        public void SetWeaponDefinition(WeaponTypeDefinition weaponType, int reachRange, int closeRange, int maxRange, List<string> weaponTags, AmmunitionTypeDefinition ammunitionType,
            EffectDescription effectDescription)

        {
            WeaponDescription weaponDefinition = new WeaponDescription();
            Traverse.Create(weaponDefinition).Field("weaponType").SetValue(weaponType.Name);
            Traverse.Create(weaponDefinition).Field("reachRange").SetValue(reachRange);
            Traverse.Create(weaponDefinition).Field("closeRange").SetValue(closeRange);
            Traverse.Create(weaponDefinition).Field("maxRange").SetValue(maxRange);
            foreach (string tagname1 in weaponTags)
            {
                weaponDefinition.WeaponTags.Add(tagname1);
            }
            Traverse.Create(weaponDefinition).Field("ammunitionType").SetValue(ammunitionType.Name);
            Traverse.Create(weaponDefinition).Field("effectDescription").SetValue(effectDescription);
            Traverse.Create(MyItem).Field("weaponDefinition").SetValue(weaponDefinition);
        }

        public void SetIsAmmunition(bool isAmmunition)
        {
            Traverse.Create(MyItem).Field("isAmmunition").SetValue(isAmmunition);
        }

        // Ammunition Definition requires Effect Description
        public void SetAmmunitionDefinition(AmmunitionTypeDefinition ammunitiontype, bool applyCharacterScale, EffectDescription effectDescription)
        {
            AmmunitionDescription ammunitionDefinition = new AmmunitionDescription();
            Traverse.Create(ammunitionDefinition).Field("ammunitionType").SetValue(ammunitiontype.Name);
            Traverse.Create(ammunitionDefinition).Field("applyCharacterScale").SetValue(applyCharacterScale);
            Traverse.Create(ammunitionDefinition).Field("effectDescription").SetValue(effectDescription);
            Traverse.Create(MyItem).Field("ammunitionDefinition").SetValue(ammunitionDefinition);
        }

        public void SetIsUsableDevice(bool isUsableDevice)
        {
            Traverse.Create(MyItem).Field("isUsableDevice").SetValue(isUsableDevice);
        }

        // Usable Device Description full version. Use this if you utilize Usable Device section for your item. 
        public void SetUsableDeviceDescription(EquipmentDefinitions.ItemUsage usage, EquipmentDefinitions.ItemChargesCapital chargesCapital, int chargesCapitalNumber, RuleDefinitions.DieType chargesCapitalDie,
            int chargesCapitalBonus, RuleDefinitions.RechargeRate rechargeRate, int rechargeNumber, RuleDefinitions.DieType rechargeDie, int rechargeBonus,
            EquipmentDefinitions.ItemOutOfCharges outOfChargesConsequence, int magicAttackBonus, int saveDC, List<DeviceFunctionDescription> deviceFunctions, List<string> usableDeviceTags,
            AssetReference onUseParticle)
        {
            UsableDeviceDescription usableDeviceDescription = new UsableDeviceDescription();
            Traverse.Create(usableDeviceDescription).Field("usage").SetValue(usage);
            Traverse.Create(usableDeviceDescription).Field("chargesCapital").SetValue(chargesCapital);
            Traverse.Create(usableDeviceDescription).Field("chargesCapitalNumber").SetValue(chargesCapitalNumber);
            Traverse.Create(usableDeviceDescription).Field("chargesCapitalDie").SetValue(chargesCapitalDie);
            Traverse.Create(usableDeviceDescription).Field("chargesCapitalBonus").SetValue(chargesCapitalBonus);
            Traverse.Create(usableDeviceDescription).Field("rechargeRate").SetValue(rechargeRate);
            Traverse.Create(usableDeviceDescription).Field("rechargeNumber").SetValue(rechargeNumber);
            Traverse.Create(usableDeviceDescription).Field("rechargeDie").SetValue(rechargeDie);
            Traverse.Create(usableDeviceDescription).Field("rechargeBonus").SetValue(rechargeBonus);
            Traverse.Create(usableDeviceDescription).Field("outOfChargesConsequence").SetValue(outOfChargesConsequence);
            Traverse.Create(usableDeviceDescription).Field("magicAttackBonus").SetValue(magicAttackBonus);
            Traverse.Create(usableDeviceDescription).Field("saveDC").SetValue(saveDC);
            foreach (DeviceFunctionDescription functions in deviceFunctions)
            {
                usableDeviceDescription.DeviceFunctions.Add(functions);
            }
            foreach (string tags in usableDeviceTags)
            {
                usableDeviceDescription.UsableDeviceTags.Add(tags);
            }
            Traverse.Create(usableDeviceDescription).Field("onUseParticle").SetValue(onUseParticle);
            Traverse.Create(MyItem).Field("usableDeviceDescription").SetValue(usableDeviceDescription);
        }

        // Usable Device Description but default-option-only-version. Use this if your item does not need Usable Device Description setting but still wish to set default dummy values to prevent crash. 
        public void SetUsableDeviceDescriptionDefault(int chargesCapitalNumber, RuleDefinitions.RechargeRate rechargeRate, int rechargeNumber, EquipmentDefinitions.ItemOutOfCharges outOfChargesConsequence, 
            int saveDC, List<DeviceFunctionDescription> deviceFunctions, List<string> usableDeviceTags, AssetReference onUseParticle)
        {
            UsableDeviceDescription usableDeviceDescription = new UsableDeviceDescription();
            //Traverse.Create(usableDeviceDescription).Field("usage").SetValue(usage);
            //Traverse.Create(usableDeviceDescription).Field("chargesCapital").SetValue(chargesCapital);
            Traverse.Create(usableDeviceDescription).Field("chargesCapitalNumber").SetValue(chargesCapitalNumber);
            //Traverse.Create(usableDeviceDescription).Field("chargesCapitalDie").SetValue(chargesCapitalDie);
            //Traverse.Create(usableDeviceDescription).Field("chargesCapitalBonus").SetValue(chargesCapitalBonus);
            Traverse.Create(usableDeviceDescription).Field("rechargeRate").SetValue(rechargeRate);
            Traverse.Create(usableDeviceDescription).Field("rechargeNumber").SetValue(rechargeNumber);
            //Traverse.Create(usableDeviceDescription).Field("rechargeDie").SetValue(rechargeDie);
            //Traverse.Create(usableDeviceDescription).Field("rechargeBonus").SetValue(rechargeBonus);
            Traverse.Create(usableDeviceDescription).Field("outOfChargesConsequence").SetValue(outOfChargesConsequence);
            //Traverse.Create(usableDeviceDescription).Field("magicAttackBonus").SetValue(magicAttackBonus);
            Traverse.Create(usableDeviceDescription).Field("saveDC").SetValue(saveDC);
            foreach (DeviceFunctionDescription functions in deviceFunctions)
            {
                usableDeviceDescription.DeviceFunctions.Add(functions);
            }
            foreach (string tags in usableDeviceTags)
            {
                usableDeviceDescription.UsableDeviceTags.Add(tags);
            }
            Traverse.Create(usableDeviceDescription).Field("onUseParticle").SetValue(onUseParticle);
            Traverse.Create(MyItem).Field("usableDeviceDescription").SetValue(usableDeviceDescription);
        }

        public void SetIsTool(bool isTool)
        {
            Traverse.Create(MyItem).Field("isTool").SetValue(isTool);
        }

        public void SetToolDefinition(ToolTypeDefinition toolType)
        {
            ToolDescription toolDefinition = new ToolDescription();
            Traverse.Create(toolDefinition).Field("toolType").SetValue(toolType.Name);
            Traverse.Create(MyItem).Field("toolDefinition").SetValue(toolDefinition);
        }

        public void SetIsStarterPack(bool isStarterPack)
        {
            Traverse.Create(MyItem).Field("isStarterPack").SetValue(isStarterPack);
        }

        public void SetStarterPackDefinition(string containerItem, List<ItemOccurence> itemOccurencesList)
        {
            StarterPackDescription starterPackDefinition = new StarterPackDescription();
            Traverse.Create(starterPackDefinition).Field("containerItem").SetValue(containerItem);
            foreach (ItemOccurence occurence in itemOccurencesList)
            {
                starterPackDefinition.ItemOccurencesList.Add(occurence);
            }
            Traverse.Create(MyItem).Field("starterPackDefinition").SetValue(starterPackDefinition);
        }

        public void SetIsContainerItem(bool isContainerItem)
        {
            Traverse.Create(MyItem).Field("isContainerItem").SetValue(isContainerItem);
        }

        public void SetContainerItemDefinition(bool personalContainer, float weightCapacityMultiplier, float weightCapacity, ContainerItemDescription.WeightComputation weightComputationMethod,
            int slotsPerRow, int minSlotsNumber)
        {
            ContainerItemDescription containerItemDefinition = new ContainerItemDescription();
            Traverse.Create(containerItemDefinition).Field("personalContainer").SetValue(personalContainer);
            Traverse.Create(containerItemDefinition).Field("weightCapacityMultiplier").SetValue(weightCapacityMultiplier);
            Traverse.Create(containerItemDefinition).Field("weightCapacity").SetValue(weightCapacity);
            Traverse.Create(containerItemDefinition).Field("weightComputationMethod").SetValue(weightComputationMethod);
            Traverse.Create(containerItemDefinition).Field("slotsPerRow").SetValue(slotsPerRow);
            Traverse.Create(containerItemDefinition).Field("minSlotsNumber").SetValue(minSlotsNumber);
            Traverse.Create(MyItem).Field("containerItemDefinition").SetValue(containerItemDefinition);
        }

        public void SetIsLightSourceItem(bool isLightSourceItem)
        {
            Traverse.Create(MyItem).Field("isLightSourceItem").SetValue(isLightSourceItem);
        }

        public void SetLightSourceItemDefinition(RuleDefinitions.LightSourceType lightSourceType, int brightRange, int dimAdditionalRange, Color color, RuleDefinitions.DurationType durationType,
            int durationValue, AssetReferenceSprite activeSpriteReference)
        {
            LightSourceItemDescription lightSourceItemDefinition = new LightSourceItemDescription();
            Traverse.Create(lightSourceItemDefinition).Field("lightSourceType").SetValue(lightSourceType);
            Traverse.Create(lightSourceItemDefinition).Field("brightRange").SetValue(brightRange);
            Traverse.Create(lightSourceItemDefinition).Field("dimAdditionalRange").SetValue(dimAdditionalRange);
            Traverse.Create(lightSourceItemDefinition).Field("color").SetValue(color);
            Traverse.Create(lightSourceItemDefinition).Field("durationType").SetValue(durationType);
            Traverse.Create(lightSourceItemDefinition).Field("durationValue").SetValue(durationValue);
            Traverse.Create(lightSourceItemDefinition).Field("activeSpriteReference").SetValue(activeSpriteReference);
            Traverse.Create(MyItem).Field("lightSourceItemDefinition").SetValue(lightSourceItemDefinition);
        }

        public void SetIsFocusItem(bool isFocusItem)
        {
            Traverse.Create(MyItem).Field("isFocusItem").SetValue(isFocusItem);
        }

        public void SetFocusItemDefinition(EquipmentDefinitions.FocusType focusType, bool shownAsFocus)
        {
            FocusItemDescription focusItemDefinition = new FocusItemDescription();
            Traverse.Create(focusItemDefinition).Field("focusType").SetValue(focusType);
            Traverse.Create(focusItemDefinition).Field("shownAsFocus").SetValue(shownAsFocus);
            Traverse.Create(MyItem).Field("focusItemDefinition").SetValue(focusItemDefinition);
        }

        public void SetIsWealthPile(bool isWealthPile)
        {
            Traverse.Create(MyItem).Field("isWealthPile").SetValue(isWealthPile);
        }

        // Array has 5 elements limit. Don't put more than 5 elements.
        public void SetWealthPileDefinition(IEnumerable<int> wealth, IEnumerable<RuleDefinitions.DieType> diceType, IEnumerable<int> bonuses)
        {
            WealthPileDescription wealthPileDefinition = new WealthPileDescription();
            if (wealth.Count() != 5) { throw new ArgumentException("Please supply exactly 5 elements"); }
            if (diceType.Count() != 5) { throw new ArgumentException("Please supply exactly 5 elements"); }
            if (bonuses.Count() != 5) { throw new ArgumentException("Please supply exactly 5 elements"); }
            Traverse.Create(wealthPileDefinition).Field("wealth").SetValue(wealth.ToArray());
            Traverse.Create(wealthPileDefinition).Field("diceTypes").SetValue(diceType.ToArray());
            Traverse.Create(wealthPileDefinition).Field("bonuses").SetValue(bonuses.ToArray());
            Traverse.Create(MyItem).Field("wealthPileDefinition").SetValue(wealthPileDefinition);
        }

        public void SetIsSpellbook(bool isSpellbook)
        {
            Traverse.Create(MyItem).Field("isSpellbook").SetValue(isSpellbook);
        }

        public void SetSpellbookDefinition(int pagesCapacity)
        {
            SpellbookDescription spellbookDefinition = new SpellbookDescription();
            Traverse.Create(spellbookDefinition).Field("pagesCapacity").SetValue(pagesCapacity);
            Traverse.Create(MyItem).Field("spellbookDefinition").SetValue(spellbookDefinition);
        }


        public void SetIsDocument(bool isDocument)
        {
            Traverse.Create(MyItem).Field("isDocument").SetValue(isDocument);
        }

        // Document Description full version. Use this if you utilize Document Description section for your item. 
        public void SetDocumentDescription(DocumentDescription.FormatType format, List<ContentFragmentDescription> contentFragments, DocumentDescription.ScriptType script, string language,
            RuleDefinitions.LoreType loreType, RecipeDefinition recipeDefinition, LocationDefinition locationDefinition, GameCampaignDefinitions.NodeKnowledge locationKnowledgeLevel,
            List<MonsterKnowledgeDescription> unlockedBestiaryContent, bool destroyAfterReading)
        {
            DocumentDescription documentDescription = new DocumentDescription();
            Traverse.Create(documentDescription).Field("format").SetValue(format);
            foreach (ContentFragmentDescription fragments in contentFragments)
            {
                documentDescription.ContentFragments.Add(fragments);
            }
            Traverse.Create(documentDescription).Field("script").SetValue(script);
            Traverse.Create(documentDescription).Field("language").SetValue(language);
            Traverse.Create(documentDescription).Field("loreType").SetValue(loreType);
            Traverse.Create(documentDescription).Field("recipeDefinition").SetValue(recipeDefinition);
            Traverse.Create(documentDescription).Field("locationDefinition").SetValue(locationDefinition);
            Traverse.Create(documentDescription).Field("locationKnowledgeLevel").SetValue(locationKnowledgeLevel);
            foreach (MonsterKnowledgeDescription contents in unlockedBestiaryContent)
            {
                documentDescription.UnlockedBestiaryContent.Add(contents);
            }
            Traverse.Create(documentDescription).Field("destroyAfterReading").SetValue(destroyAfterReading);
            Traverse.Create(MyItem).Field("documentDescription").SetValue(documentDescription);
        }

        // Document Description but default-option-only-version. Use this if your item does not need Document Description setting but still wish to set default dummy values to prevent crash. 
        public void SetDocumentDescriptionDefault(List<ContentFragmentDescription> contentFragments, string language, 
            GameCampaignDefinitions.NodeKnowledge locationKnowledgeLevel, List<MonsterKnowledgeDescription> unlockedBestiaryContent)
        {
            DocumentDescription documentDescription = new DocumentDescription();
            //Traverse.Create(documentDescription).Field("format").SetValue(format);
            foreach (ContentFragmentDescription fragments in contentFragments)
            {
                documentDescription.ContentFragments.Add(fragments);
            }
            //Traverse.Create(documentDescription).Field("script").SetValue(script);
            Traverse.Create(documentDescription).Field("language").SetValue(language);
            //Traverse.Create(documentDescription).Field("loreType").SetValue(loreType);
            //Traverse.Create(documentDescription).Field("recipeDefinition").SetValue(recipeDefinition);
            //Traverse.Create(documentDescription).Field("locationDefinition").SetValue(locationDefinition);
            Traverse.Create(documentDescription).Field("locationKnowledgeLevel").SetValue(locationKnowledgeLevel);
            foreach (MonsterKnowledgeDescription contents in unlockedBestiaryContent)
            {
                documentDescription.UnlockedBestiaryContent.Add(contents);
            }
            //Traverse.Create(documentDescription).Field("destroyAfterReading").SetValue(destroyAfterReading);
            Traverse.Create(MyItem).Field("documentDescription").SetValue(documentDescription);
        }

        public void SetIsFood(bool isFood)
        {
            Traverse.Create(MyItem).Field("isFood").SetValue(isFood);
        }

        public void SetFoodDescription(int nutritiveCapacity, bool perishable)
        {
            FoodDescription foodDescription = new FoodDescription();
            Traverse.Create(foodDescription).Field("nutritiveCapacity").SetValue(nutritiveCapacity);
            Traverse.Create(foodDescription).Field("perishable").SetValue(perishable);
            Traverse.Create(MyItem).Field("foodDescription").SetValue(foodDescription);
        }

        public void SetIsFactionRelic(bool isFactionRelic)
        {
            Traverse.Create(MyItem).Field("isFactionRelic").SetValue(isFactionRelic);
        }

        // Array has 5 elements limit. Don't put more than 5 elements.
        public void SetFactionRelicDescription(int loreValue, List<string> interestedFactions, IEnumerable<int> redeemCosts)
        {
            FactionRelicDescription factionRelicDescription = new FactionRelicDescription();
            Traverse.Create(factionRelicDescription).Field("loreValue").SetValue(loreValue);
            foreach (string factions in interestedFactions)
            {
                factionRelicDescription.InterestedFactions.Add(factions);
            }
            if (redeemCosts.Count() != 5) { throw new ArgumentException("Please supply exactly 5 elements"); }
            Traverse.Create(factionRelicDescription).Field("wealth").SetValue(redeemCosts.ToArray());
            Traverse.Create(MyItem).Field("factionRelicDescription").SetValue(factionRelicDescription);
        }

        public void SetPersonalityFlagOccurences(List<PersonalityFlagOccurence> personalityFlagOccurences)
        {
            foreach (PersonalityFlagOccurence occurence in personalityFlagOccurences)
            {
                MyItem.PersonalityFlagOccurences.Add(occurence);
            }
        }

        public void SetSoundEffectDescriptionOverride(AK.Wwise.Event startEvent, AK.Wwise.Event stopEvent, AK.Wwise.Switch startSwitch, AK.Wwise.Switch stopSwitch, AK.Wwise.Event guiStoreBody,
            AK.Wwise.Event guiPickBody, AK.Wwise.Event guiStoreOther, AK.Wwise.Event guiPickOther)
        {
            SoundEffectDescription soundEffect = new SoundEffectDescription();
            Traverse.Create(soundEffect).Field("startEvent").SetValue(startEvent);
            Traverse.Create(soundEffect).Field("stopEvent").SetValue(stopEvent);
            Traverse.Create(soundEffect).Field("startSwitch").SetValue(startSwitch);
            Traverse.Create(soundEffect).Field("stopSwitch").SetValue(stopSwitch);
            Traverse.Create(soundEffect).Field("guiStoreBody").SetValue(guiStoreBody);
            Traverse.Create(soundEffect).Field("guiPickBody").SetValue(guiPickBody);
            Traverse.Create(soundEffect).Field("guiStoreOther").SetValue(guiStoreOther);
            Traverse.Create(soundEffect).Field("guiPickOther").SetValue(guiPickOther);
            Traverse.Create(MyItem).Field("soundEffectDescriptionOverride").SetValue(soundEffect);
        }

        public void SetSoundEffectOnHitDescriptionOverride(AK.Wwise.Switch switchOnHit)
        {
            SoundEffectOnHitDescription soundEffectOnHit = new SoundEffectOnHitDescription();
            Traverse.Create(soundEffectOnHit).Field("switchOnHit").SetValue(switchOnHit);
            Traverse.Create(MyItem).Field("soundEffectOnHitDescriptionOverride").SetValue(soundEffectOnHit);
        }

        public void SetItemPresentation(string unidentifiedTitle, string unidentifiedDescription, string overrideSubtype, AssetReference assetReference, bool useArmorAddressableName, 
            string armorAddressableName, bool useCustomArmorMaterial, string customArmorMaterial, bool hasCrownVariationMask, int crownVariationMask, bool sameBehavioursForMaleAndFemale, 
            IEnumerable<GraphicsCharacterDefinitions.BodyPartBehaviour> maleBodyPartBehaviours, IEnumerable<GraphicsCharacterDefinitions.BodyPartBehaviour> femaleBodyPartBehaviours)
        {
            ItemPresentation itemPresentation = new ItemPresentation();
            Traverse.Create(itemPresentation).Field("unidentifiedTitle").SetValue(unidentifiedTitle);
            Traverse.Create(itemPresentation).Field("unidentifiedDescription").SetValue(unidentifiedDescription);
            Traverse.Create(itemPresentation).Field("overrideSubtype").SetValue(overrideSubtype);
            Traverse.Create(itemPresentation).Field("assetReference").SetValue(assetReference);
            Traverse.Create(itemPresentation).Field("useArmorAddressableName").SetValue(useArmorAddressableName);
            Traverse.Create(itemPresentation).Field("armorAddressableName").SetValue(armorAddressableName);
            Traverse.Create(itemPresentation).Field("useCustomArmorMaterial").SetValue(useCustomArmorMaterial);
            Traverse.Create(itemPresentation).Field("customArmorMaterial").SetValue(customArmorMaterial);
            Traverse.Create(itemPresentation).Field("hasCrownVariationMask").SetValue(hasCrownVariationMask);
            Traverse.Create(itemPresentation).Field("crownVariationMask").SetValue(crownVariationMask);
            Traverse.Create(itemPresentation).Field("sameBehavioursForMaleAndFemale").SetValue(sameBehavioursForMaleAndFemale);
            Traverse.Create(itemPresentation).Field("maleBodyPartBehaviours").SetValue(maleBodyPartBehaviours.ToArray());
            Traverse.Create(itemPresentation).Field("femaleBodyPartBehaviours").SetValue(femaleBodyPartBehaviours.ToArray());
            Traverse.Create(MyItem).Field("itemPresentation").SetValue(itemPresentation);
        }


        public void SetName(string name, string guid)
        {
            Traverse.Create(MyItem).Field("name").SetValue(name);
            MyItem.name = name;
            //Traverse.Create(MyItem).Field("guid").SetValue(GuidHelper.Create(Main.ModGuidNamespace, name).ToString());
            Traverse.Create(MyItem).Field("guid").SetValue(guid);
        }

        public void SetGuiPresentation(GuiPresentation gui)
        {
            Traverse.Create(MyItem).Field("guiPresentation").SetValue(gui);
        }

        public ItemDefinition AddToDB()
        {
            Database<ItemDefinition> ItemDatabase = DatabaseRepository.GetDatabase<ItemDefinition>();
            // add new item to db
            ItemDatabase.Add(MyItem);
            return MyItem;
        }
    }
}

