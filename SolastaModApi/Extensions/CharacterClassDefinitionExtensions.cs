using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using TA.AI;
using static RuleDefinitions;
using static AnimationDefinitions;

namespace SolastaModApi
{
    public static class CharacterClassDefinitionExtensions
    {
        public static T SetClassAnimationId<T>(this T entity, ClassAnimationId value)
            where T : CharacterClassDefinition
        {
            entity.SetField("classAnimationId", value);
            return entity;
        }

        public static T SetClassPictogramReference<T>(this T entity, AssetReferenceSprite value)
            where T : CharacterClassDefinition
        {
            entity.SetField("classPictogramReference", value);
            return entity;
        }

        public static T SetDefaultBattleDecisions<T>(this T entity, DecisionPackageDefinition value)
            where T : CharacterClassDefinition
        {
            entity.SetField("defaultBattleDecisions", value);
            return entity;
        }

        public static T SetHitDice<T>(this T entity, DieType value)
            where T : CharacterClassDefinition
        {
            entity.SetField("hitDice", value);
            return entity;
        }

        public static T SetIngredientGatheringOdds<T>(this T entity, int value)
            where T : CharacterClassDefinition
        {
            entity.SetField("ingredientGatheringOdds", value);
            return entity;
        }

        public static T SetRequiresDeity<T>(this T entity, bool value)
            where T : CharacterClassDefinition
        {
            entity.SetField("requiresDeity", value);
            return entity;
        }
    }
}