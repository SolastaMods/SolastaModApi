using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionPerceptionAffinityExtensions
    {
        public static T SetCannotBeSurprised<T>(this T entity, bool value)
            where T : FeatureDefinitionPerceptionAffinity
        {
            entity.SetField("cannotBeSurprised", value);
            return entity;
        }

        public static T SetCharacterFamilyRevealed<T>(this T entity, bool value)
            where T : FeatureDefinitionPerceptionAffinity
        {
            entity.SetField("characterFamilyRevealed", value);
            return entity;
        }

        public static T SetCharacterPositionRevealed<T>(this T entity, bool value)
            where T : FeatureDefinitionPerceptionAffinity
        {
            entity.SetField("characterPositionRevealed", value);
            return entity;
        }

        public static T SetImpairedSight<T>(this T entity, bool value)
            where T : FeatureDefinitionPerceptionAffinity
        {
            entity.SetField("impairedSight", value);
            return entity;
        }
    }
}