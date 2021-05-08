using TA.AI;
using UnityEngine.AddressableAssets;
using System.Collections.Generic;
using static CharacterClassDefinition;
using System;

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

        public CharacterClassDefinitionBuilder(string name, Guid guidNamespace) : base(name, guidNamespace)
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
            Definition.PersonalityFlagOccurences.Add(PersonalityFlagOccurenceExtensions.Create(weight, personalityType.Name));
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

        public CharacterClassDefinitionBuilder SetGuiPresentation(GuiPresentation gui)
        {
            Definition.SetGuiPresentation(gui);
            return this;
        }

        public CharacterClassDefinitionBuilder AddEquipmentRow(List<HeroEquipmentOption> equipmentList)
        {
            var equipmentColumn = new HeroEquipmentColumn();
            equipmentColumn.EquipmentOptions.AddRange(equipmentList);

            var equipmentRow = new HeroEquipmentRow();
            equipmentRow.EquipmentColumns.Add(equipmentColumn);

            Definition.EquipmentRows.Add(equipmentRow);

            return this;
        }

        public CharacterClassDefinitionBuilder AddEquipmentRow(List<HeroEquipmentOption> equipmentListA, List<HeroEquipmentOption> equipmentListB)
        {
            var equipmentColumnA = new HeroEquipmentColumn();
            equipmentColumnA.EquipmentOptions.AddRange(equipmentListA);

            var equipmentColumnB = new HeroEquipmentColumn();
            equipmentColumnB.EquipmentOptions.AddRange(equipmentListB);

            var equipmentRow = new HeroEquipmentRow();
            equipmentRow.EquipmentColumns.Add(equipmentColumnA);
            equipmentRow.EquipmentColumns.Add(equipmentColumnB);

            Definition.EquipmentRows.Add(equipmentRow);
            
            return this;
        }

        public CharacterClassDefinitionBuilder AddFeatureAtLevel(FeatureDefinition feature, int level)
        {
            Definition.FeatureUnlocks.Add(new FeatureUnlockByLevel(feature, level));
            return this;
        }

        public FeatureDefinitionSubclassChoice BuildSubclassChoice(int level, string subclassSuffix, bool requireDeity, string name, GuiPresentation guiPresentation, Guid modGuidNamespace)
        {
            var builder = new FeatureDefinitionSubclassChoiceBuilder(name, modGuidNamespace);

            return BuildSubclassChoice(builder, level, subclassSuffix, requireDeity, guiPresentation);
        }

        public FeatureDefinitionSubclassChoice BuildSubclassChoice(int level, string subclassSuffix, bool requireDeity, string name, GuiPresentation guiPresentation, string guid)
        {
            var builder = new FeatureDefinitionSubclassChoiceBuilder(name, guid);

            return BuildSubclassChoice(builder, level, subclassSuffix, requireDeity, guiPresentation);
        }

        private FeatureDefinitionSubclassChoice BuildSubclassChoice(FeatureDefinitionSubclassChoiceBuilder builder, int level, string subclassSuffix, bool requireDeity, GuiPresentation guiPresentation)
        {
            var subclassChoice = builder
                .SetSubclassSuffix(subclassSuffix)
                .SetFilterByDeity(requireDeity)
                .SetGuiPresentation(guiPresentation)
                .AddToDB();

            AddFeatureAtLevel(subclassChoice, level);

            return subclassChoice;
        }
    }
}
