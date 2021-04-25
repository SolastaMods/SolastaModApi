using SolastaModApi.Infrastructure;
using AK.Wwise;
using UnityEngine.AddressableAssets;
using System.Collections.Generic;
using static CampaignDefinition;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class LocationDefinitionExtensions
    {
        public static LocationDefinition SetAlwaysHidden(this LocationDefinition definition, bool value)
        {
            definition.SetField("alwaysHidden", value);
            return definition;
        }

        public static LocationDefinition SetAudioState(this LocationDefinition definition, State value)
        {
            definition.SetField("audioState", value);
            return definition;
        }

        public static LocationDefinition SetChallengeRating(this LocationDefinition definition, int value)
        {
            definition.SetField("challengeRating", value);
            return definition;
        }

        public static LocationDefinition SetFocusWhenRevealed(this LocationDefinition definition, bool value)
        {
            definition.SetField("focusWhenRevealed", value);
            return definition;
        }

        public static LocationDefinition SetIgnoredByScavengers(this LocationDefinition definition, bool value)
        {
            definition.SetField("ignoredByScavengers", value);
            return definition;
        }

        public static LocationDefinition SetIsUserLocation(this LocationDefinition definition, bool value)
        {
            definition.SetField("isUserLocation", value);
            return definition;
        }

        public static LocationDefinition SetKeepSectorCullingResultsWhenInactive(this LocationDefinition definition, bool value)
        {
            definition.SetField("keepSectorCullingResultsWhenInactive", value);
            return definition;
        }

        public static LocationDefinition SetLocationPresentation(this LocationDefinition definition, LocationPresentation value)
        {
            definition.SetField("locationPresentation", value);
            return definition;
        }

        public static LocationDefinition SetRegisteredFactions(this LocationDefinition definition, List<FactionRegistration> value)
        {
            definition.SetField("registeredFactions", value);
            return definition;
        }

        public static LocationDefinition SetRegisteredVariables(this LocationDefinition definition, List<VariableRegistrationDescription> value)
        {
            definition.SetField("registeredVariables", value);
            return definition;
        }

        public static LocationDefinition SetSceneFilePath(this LocationDefinition definition, string value)
        {
            definition.SetField("sceneFilePath", value);
            return definition;
        }

        public static LocationDefinition SetSceneReference(this LocationDefinition definition, AssetReference value)
        {
            definition.SetField("sceneReference", value);
            return definition;
        }

        public static LocationDefinition SetSetCurrentCampaignNodeWhenLeaving(this LocationDefinition definition, bool value)
        {
            definition.SetField("setCurrentCampaignNodeWhenLeaving", value);
            return definition;
        }

        public static LocationDefinition SetStartsWithScavengerCamp(this LocationDefinition definition, bool value)
        {
            definition.SetField("startsWithScavengerCamp", value);
            return definition;
        }
    }
}