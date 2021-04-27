using SolastaModApi.Infrastructure;
using AK.Wwise;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    public static class LocationDefinitionExtensions
    {
        public static T SetAlwaysHidden<T>(this T definition, bool value)
            where T : LocationDefinition
        {
            definition.SetField("alwaysHidden", value);
            return definition;
        }

        public static T SetAudioState<T>(this T definition, State value)
            where T : LocationDefinition
        {
            definition.SetField("audioState", value);
            return definition;
        }

        public static T SetChallengeRating<T>(this T definition, int value)
            where T : LocationDefinition
        {
            definition.SetField("challengeRating", value);
            return definition;
        }

        public static T SetFocusWhenRevealed<T>(this T definition, bool value)
            where T : LocationDefinition
        {
            definition.SetField("focusWhenRevealed", value);
            return definition;
        }

        public static T SetIgnoredByScavengers<T>(this T definition, bool value)
            where T : LocationDefinition
        {
            definition.SetField("ignoredByScavengers", value);
            return definition;
        }

        public static T SetIsUserLocation<T>(this T definition, bool value)
            where T : LocationDefinition
        {
            definition.SetField("isUserLocation", value);
            return definition;
        }

        public static T SetKeepSectorCullingResultsWhenInactive<T>(this T definition, bool value)
            where T : LocationDefinition
        {
            definition.SetField("keepSectorCullingResultsWhenInactive", value);
            return definition;
        }

        public static T SetLocationPresentation<T>(this T definition, LocationPresentation value)
            where T : LocationDefinition
        {
            definition.SetField("locationPresentation", value);
            return definition;
        }

        public static T SetSceneFilePath<T>(this T definition, string value)
            where T : LocationDefinition
        {
            definition.SetField("sceneFilePath", value);
            return definition;
        }

        public static T SetSceneReference<T>(this T definition, AssetReference value)
            where T : LocationDefinition
        {
            definition.SetField("sceneReference", value);
            return definition;
        }

        public static T SetSetCurrentCampaignNodeWhenLeaving<T>(this T definition, bool value)
            where T : LocationDefinition
        {
            definition.SetField("setCurrentCampaignNodeWhenLeaving", value);
            return definition;
        }

        public static T SetStartsWithScavengerCamp<T>(this T definition, bool value)
            where T : LocationDefinition
        {
            definition.SetField("startsWithScavengerCamp", value);
            return definition;
        }
    }
}