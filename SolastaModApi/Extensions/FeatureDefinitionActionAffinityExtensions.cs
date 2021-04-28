using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionActionAffinityExtensions
    {
        public static T SetEitherMainOrBonus<T>(this T entity, bool value)
            where T : FeatureDefinitionActionAffinity
        {
            entity.SetField("eitherMainOrBonus", value);
            return entity;
        }

        public static T SetMaxAttacksNumber<T>(this T entity, int value)
            where T : FeatureDefinitionActionAffinity
        {
            entity.SetField("maxAttacksNumber", value);
            return entity;
        }

        public static T SetRandomBehaviorDie<T>(this T entity, DieType value)
            where T : FeatureDefinitionActionAffinity
        {
            entity.SetField("randomBehaviorDie", value);
            return entity;
        }

        public static T SetSpecialBehaviour<T>(this T entity, SpecialBehaviour value)
            where T : FeatureDefinitionActionAffinity
        {
            entity.SetField("specialBehaviour", value);
            return entity;
        }
    }
}