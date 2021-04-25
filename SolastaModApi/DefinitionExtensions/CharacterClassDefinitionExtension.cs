using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using TA.AI;
using System.Collections.Generic;
using static RuleDefinitions;
using static AnimationDefinitions;
using static CharacterClassDefinition;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CharacterClassDefinitionExtensions
    {
        public static CharacterClassDefinition SetAbilityScoresPriority(this CharacterClassDefinition definition, List<string> value)
        {
            definition.SetField("abilityScoresPriority", value);
            return definition;
        }

        public static CharacterClassDefinition SetClassAnimationId(this CharacterClassDefinition definition, ClassAnimationId value)
        {
            definition.SetField("classAnimationId", value);
            return definition;
        }

        public static CharacterClassDefinition SetClassPictogramReference(this CharacterClassDefinition definition, AssetReferenceSprite value)
        {
            definition.SetField("classPictogramReference", value);
            return definition;
        }

        public static CharacterClassDefinition SetDefaultBattleDecisions(this CharacterClassDefinition definition, DecisionPackageDefinition value)
        {
            definition.SetField("defaultBattleDecisions", value);
            return definition;
        }

        public static CharacterClassDefinition SetEquipmentRows(this CharacterClassDefinition definition, List<HeroEquipmentRow> value)
        {
            definition.SetField("equipmentRows", value);
            return definition;
        }

        public static CharacterClassDefinition SetExpertiseAutolearnPreference(this CharacterClassDefinition definition, List<string> value)
        {
            definition.SetField("expertiseAutolearnPreference", value);
            return definition;
        }

        public static CharacterClassDefinition SetFeatAutolearnPreference(this CharacterClassDefinition definition, List<string> value)
        {
            definition.SetField("featAutolearnPreference", value);
            return definition;
        }

        public static CharacterClassDefinition SetFeatureUnlocks(this CharacterClassDefinition definition, List<FeatureUnlockByLevel> value)
        {
            definition.SetField("featureUnlocks", value);
            return definition;
        }

        public static CharacterClassDefinition SetHitDice(this CharacterClassDefinition definition, DieType value)
        {
            definition.SetField("hitDice", value);
            return definition;
        }

        public static CharacterClassDefinition SetIngredientGatheringOdds(this CharacterClassDefinition definition, int value)
        {
            definition.SetField("ingredientGatheringOdds", value);
            return definition;
        }

        public static CharacterClassDefinition SetPersonalityFlagOccurences(this CharacterClassDefinition definition, List<PersonalityFlagOccurence> value)
        {
            definition.SetField("personalityFlagOccurences", value);
            return definition;
        }

        public static CharacterClassDefinition SetRequiresDeity(this CharacterClassDefinition definition, bool value)
        {
            definition.SetField("requiresDeity", value);
            return definition;
        }

        public static CharacterClassDefinition SetSkillAutolearnPreference(this CharacterClassDefinition definition, List<string> value)
        {
            definition.SetField("skillAutolearnPreference", value);
            return definition;
        }

        public static CharacterClassDefinition SetToolAutolearnPreference(this CharacterClassDefinition definition, List<string> value)
        {
            definition.SetField("toolAutolearnPreference", value);
            return definition;
        }
    }
}