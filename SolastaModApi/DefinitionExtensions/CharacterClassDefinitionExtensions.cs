using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using TA.AI;
using System.Collections.Generic;
using static RuleDefinitions;
using static AnimationDefinitions;
using static CharacterClassDefinition;

namespace SolastaModApi
{
    public static class CharacterClassDefinitionExtensions
    {
        public static T SetAbilityScoresPriority<T>(this T definition, List<string> value)
            where T : CharacterClassDefinition
        {
            definition.SetField("abilityScoresPriority", value);
            return definition;
        }

        public static T SetClassAnimationId<T>(this T definition, ClassAnimationId value)
            where T : CharacterClassDefinition
        {
            definition.SetField("classAnimationId", value);
            return definition;
        }

        public static T SetClassPictogramReference<T>(this T definition, AssetReferenceSprite value)
            where T : CharacterClassDefinition
        {
            definition.SetField("classPictogramReference", value);
            return definition;
        }

        public static T SetDefaultBattleDecisions<T>(this T definition, DecisionPackageDefinition value)
            where T : CharacterClassDefinition
        {
            definition.SetField("defaultBattleDecisions", value);
            return definition;
        }

        public static T SetEquipmentRows<T>(this T definition, List<HeroEquipmentRow> value)
            where T : CharacterClassDefinition
        {
            definition.SetField("equipmentRows", value);
            return definition;
        }

        public static T SetExpertiseAutolearnPreference<T>(this T definition, List<string> value)
            where T : CharacterClassDefinition
        {
            definition.SetField("expertiseAutolearnPreference", value);
            return definition;
        }

        public static T SetFeatAutolearnPreference<T>(this T definition, List<string> value)
            where T : CharacterClassDefinition
        {
            definition.SetField("featAutolearnPreference", value);
            return definition;
        }

        public static T SetFeatureUnlocks<T>(this T definition, List<FeatureUnlockByLevel> value)
            where T : CharacterClassDefinition
        {
            definition.SetField("featureUnlocks", value);
            return definition;
        }

        public static T SetHitDice<T>(this T definition, DieType value)
            where T : CharacterClassDefinition
        {
            definition.SetField("hitDice", value);
            return definition;
        }

        public static T SetIngredientGatheringOdds<T>(this T definition, int value)
            where T : CharacterClassDefinition
        {
            definition.SetField("ingredientGatheringOdds", value);
            return definition;
        }

        public static T SetPersonalityFlagOccurences<T>(this T definition, List<PersonalityFlagOccurence> value)
            where T : CharacterClassDefinition
        {
            definition.SetField("personalityFlagOccurences", value);
            return definition;
        }

        public static T SetRequiresDeity<T>(this T definition, bool value)
            where T : CharacterClassDefinition
        {
            definition.SetField("requiresDeity", value);
            return definition;
        }

        public static T SetSkillAutolearnPreference<T>(this T definition, List<string> value)
            where T : CharacterClassDefinition
        {
            definition.SetField("skillAutolearnPreference", value);
            return definition;
        }

        public static T SetToolAutolearnPreference<T>(this T definition, List<string> value)
            where T : CharacterClassDefinition
        {
            definition.SetField("toolAutolearnPreference", value);
            return definition;
        }
    }
}