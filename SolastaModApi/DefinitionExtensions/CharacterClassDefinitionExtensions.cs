using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using TA.AI;
using static RuleDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi
{
    public static class CharacterClassDefinitionExtensions
    {
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

        public static T SetRequiresDeity<T>(this T definition, bool value)
            where T : CharacterClassDefinition
        {
            definition.SetField("requiresDeity", value);
            return definition;
        }
    }
}