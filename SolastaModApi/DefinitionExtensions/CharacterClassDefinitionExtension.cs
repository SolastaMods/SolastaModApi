using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using System;
using TA.AI;
using System.Collections.Generic;
using static RuleDefinitions;
using static AnimationDefinitions;
using static CharacterClassDefinition;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CharacterClassDefinitionExtensions
    {
        public static void SetAbilityScoresPriority(this CharacterClassDefinition definition, List<String> value)
        {
            definition.SetField("abilityScoresPriority", value);
        }

        public static void SetClassAnimationId(this CharacterClassDefinition definition, ClassAnimationId value)
        {
            definition.SetField("classAnimationId", value);
        }

        public static void SetClassPictogramReference(this CharacterClassDefinition definition, AssetReferenceSprite value)
        {
            definition.SetField("classPictogramReference", value);
        }

        public static void SetDefaultBattleDecisions(this CharacterClassDefinition definition, DecisionPackageDefinition value)
        {
            definition.SetField("defaultBattleDecisions", value);
        }

        public static void SetEquipmentRows(this CharacterClassDefinition definition, List<HeroEquipmentRow> value)
        {
            definition.SetField("equipmentRows", value);
        }

        public static void SetExpertiseAutolearnPreference(this CharacterClassDefinition definition, List<String> value)
        {
            definition.SetField("expertiseAutolearnPreference", value);
        }

        public static void SetFeatAutolearnPreference(this CharacterClassDefinition definition, List<String> value)
        {
            definition.SetField("featAutolearnPreference", value);
        }

        public static void SetFeatureUnlocks(this CharacterClassDefinition definition, List<FeatureUnlockByLevel> value)
        {
            definition.SetField("featureUnlocks", value);
        }

        public static void SetHitDice(this CharacterClassDefinition definition, DieType value)
        {
            definition.SetField("hitDice", value);
        }

        public static void SetIngredientGatheringOdds(this CharacterClassDefinition definition, Int32 value)
        {
            definition.SetField("ingredientGatheringOdds", value);
        }

        public static void SetPersonalityFlagOccurences(this CharacterClassDefinition definition, List<PersonalityFlagOccurence> value)
        {
            definition.SetField("personalityFlagOccurences", value);
        }

        public static void SetRequiresDeity(this CharacterClassDefinition definition, Boolean value)
        {
            definition.SetField("requiresDeity", value);
        }

        public static void SetSkillAutolearnPreference(this CharacterClassDefinition definition, List<String> value)
        {
            definition.SetField("skillAutolearnPreference", value);
        }

        public static void SetToolAutolearnPreference(this CharacterClassDefinition definition, List<String> value)
        {
            definition.SetField("toolAutolearnPreference", value);
        }
    }
}