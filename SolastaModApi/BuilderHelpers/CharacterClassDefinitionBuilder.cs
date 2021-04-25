using HarmonyLib;
using TA.AI;
using UnityEngine;
using UnityEngine.AddressableAssets;
using System.Collections.Generic;
using static CharacterClassDefinition;
using SolastaModApi.BuilderHelpers;
using SolastaModApi.BuilderHelpers.DefinitionExtensions;
using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    /// <summary>
    /// Example drop in replacement for ClassBuilder
    /// </summary>
    public class CharacterClassDefinitionBuilder : BaseDefinitionBuilder<CharacterClassDefinition>
    {
        public CharacterClassDefinitionBuilder(string name, string guid) : base(name, guid)
        {
        }

        public CharacterClassDefinitionBuilder SetHitDice(RuleDefinitions.DieType die)
        {
            Definition.SetHitDice(die);
            return this;
        }

        public CharacterClassDefinitionBuilder SetAbilityScorePriorities(string first, string second, string third, string fourth, string fifth, string sixth)
        {
            Definition.AbilityScoresPriority.Clear();
            Definition.AbilityScoresPriority.AddRange(new[] { first, second, third, fourth, fifth, sixth });
            return this;
        }

        public CharacterClassDefinitionBuilder AddPersonality(PersonalityFlagDefinition personalityType, int weight)
        {
            PersonalityFlagOccurence personality = new PersonalityFlagOccurence();

            personality.SetField("weight", weight);
            personality.SetField("personalityFlag", personalityType.Name);

            Definition.PersonalityFlagOccurences.Add(personality);
            return this;
        }

        public CharacterClassDefinitionBuilder AddToolPreference(ToolTypeDefinition toolType)
        {
            Definition.ToolAutolearnPreference.Add(toolType.Name);
            return this;
        }

        public CharacterClassDefinitionBuilder AddSkillPreference(SkillDefinition skillType)
        {
            Definition.SkillAutolearnPreference.Add(skillType.Name);
            return this;
        }

        public CharacterClassDefinitionBuilder AddExpertisePreference(SkillDefinition skillType)
        {
            Definition.ExpertiseAutolearnPreference.Add(skillType.Name);
            return this;
        }

        public CharacterClassDefinitionBuilder AddExpertisePreference(ToolTypeDefinition toolType)
        {
            Definition.ExpertiseAutolearnPreference.Add(toolType.Name);
            return this;
        }

        public CharacterClassDefinitionBuilder AddFeatPreference(FeatDefinition featType)
        {
            Definition.FeatAutolearnPreference.Add(featType.Name);
            return this;
        }

        public CharacterClassDefinitionBuilder SetIngredientGatheringOdds(int odds)
        {
            Definition.SetIngredientGatheringOdds(odds);
            return this;
        }

        public CharacterClassDefinitionBuilder SetBattleAI(DecisionPackageDefinition decisionPackage)
        {
            Definition.SetDefaultBattleDecisions(decisionPackage);
            return this;
        }

        public CharacterClassDefinitionBuilder SetPictogram(AssetReferenceSprite sprite)
        {
            Definition.SetClassPictogramReference(sprite);
            return this;
        }

        public CharacterClassDefinitionBuilder SetAnimationId(AnimationDefinitions.ClassAnimationId animId)
        {
            Definition.SetClassAnimationId(animId);
            return this;
        }

        public CharacterClassDefinitionBuilder RequireDeity()
        {
            Definition.SetRequiresDeity(true);
            return this;
        }

        public CharacterClassDefinitionBuilder AddEquipmentRow(List<HeroEquipmentOption> equipmentList)
        {
            HeroEquipmentRow equipmentRow = new HeroEquipmentRow();
            HeroEquipmentColumn equipmentColumn = new HeroEquipmentColumn();
            foreach (HeroEquipmentOption option in equipmentList)
            {
                equipmentColumn.EquipmentOptions.Add(option);
            }
            equipmentRow.EquipmentColumns.Add(equipmentColumn);
            Definition.EquipmentRows.Add(equipmentRow);
            return this;
        }

        public CharacterClassDefinitionBuilder AddEquipmentRow(List<HeroEquipmentOption> equipmentListA, List<HeroEquipmentOption> equipmentListB)
        {
            HeroEquipmentRow equipmentRow = new HeroEquipmentRow();
            HeroEquipmentColumn equipmentColumnA = new HeroEquipmentColumn();
            foreach (HeroEquipmentOption option in equipmentListA)
            {
                equipmentColumnA.EquipmentOptions.Add(option);
            }
            equipmentRow.EquipmentColumns.Add(equipmentColumnA);
            HeroEquipmentColumn equipmentColumnB = new HeroEquipmentColumn();
            foreach (HeroEquipmentOption option in equipmentListB)
            {
                equipmentColumnB.EquipmentOptions.Add(option);
            }
            equipmentRow.EquipmentColumns.Add(equipmentColumnB);
            Definition.EquipmentRows.Add(equipmentRow);
            return this;
        }

        public CharacterClassDefinitionBuilder AddFeatureAtLevel(FeatureDefinition feature, int level)
        {
            Definition.FeatureUnlocks.Add(new FeatureUnlockByLevel(feature, level));
            return this;
        }

        public FeatureDefinitionSubclassChoice BuildSubclassChoice(int level, string subclassSuffix, bool requireDeity, string name, GuiPresentation guiPresentation, string guid)
        {
            // TODO: create FeatureDefinitionSubclassChoiceBuilder derived from BaseDefinitionBuilder

            FeatureDefinitionSubclassChoice subclassChoice = ScriptableObject.CreateInstance<FeatureDefinitionSubclassChoice>();
            Traverse.Create(subclassChoice).Field("filterByDeity").SetValue(requireDeity);
            Traverse.Create(subclassChoice).Field("subclassSuffix").SetValue(subclassSuffix);
            Traverse.Create(subclassChoice).Field("name").SetValue(name);
            subclassChoice.name = name;
            Traverse.Create(subclassChoice).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(subclassChoice).Field("guid").SetValue(guid);

            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(subclassChoice);
            AddFeatureAtLevel(subclassChoice, level);
            return subclassChoice;
        }
    }
}
