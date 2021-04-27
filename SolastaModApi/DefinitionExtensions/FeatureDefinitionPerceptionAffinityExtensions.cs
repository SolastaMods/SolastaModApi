using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionPerceptionAffinityExtensions
    {
        public static T SetCannotBeSurprised<T>(this T definition, bool value)
            where T : FeatureDefinitionPerceptionAffinity
        {
            definition.SetField("cannotBeSurprised", value);
            return definition;
        }

        public static T SetCharacterFamilyRevealed<T>(this T definition, bool value)
            where T : FeatureDefinitionPerceptionAffinity
        {
            definition.SetField("characterFamilyRevealed", value);
            return definition;
        }

        public static T SetCharacterPositionRevealed<T>(this T definition, bool value)
            where T : FeatureDefinitionPerceptionAffinity
        {
            definition.SetField("characterPositionRevealed", value);
            return definition;
        }

        public static T SetImpairedSight<T>(this T definition, bool value)
            where T : FeatureDefinitionPerceptionAffinity
        {
            definition.SetField("impairedSight", value);
            return definition;
        }
    }
}