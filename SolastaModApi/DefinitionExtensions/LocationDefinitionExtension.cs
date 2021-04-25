using SolastaModApi.Infrastructure;
using AK.Wwise;
using UnityEngine.AddressableAssets;
using System;
using System.Collections.Generic;
using static CampaignDefinition;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class LocationDefinitionExtensions
    {
        public static void SetAlwaysHidden(this LocationDefinition definition, Boolean value)
        {
            definition.SetField("alwaysHidden", value);
        }

        public static void SetAudioState(this LocationDefinition definition, State value)
        {
            definition.SetField("audioState", value);
        }

        public static void SetChallengeRating(this LocationDefinition definition, Int32 value)
        {
            definition.SetField("challengeRating", value);
        }

        public static void SetFocusWhenRevealed(this LocationDefinition definition, Boolean value)
        {
            definition.SetField("focusWhenRevealed", value);
        }

        public static void SetIgnoredByScavengers(this LocationDefinition definition, Boolean value)
        {
            definition.SetField("ignoredByScavengers", value);
        }

        public static void SetIsUserLocation(this LocationDefinition definition, Boolean value)
        {
            definition.SetField("isUserLocation", value);
        }

        public static void SetKeepSectorCullingResultsWhenInactive(this LocationDefinition definition, Boolean value)
        {
            definition.SetField("keepSectorCullingResultsWhenInactive", value);
        }

        public static void SetLocationPresentation(this LocationDefinition definition, LocationPresentation value)
        {
            definition.SetField("locationPresentation", value);
        }

        public static void SetRegisteredFactions(this LocationDefinition definition, List<FactionRegistration> value)
        {
            definition.SetField("registeredFactions", value);
        }

        public static void SetRegisteredVariables(this LocationDefinition definition, List<VariableRegistrationDescription> value)
        {
            definition.SetField("registeredVariables", value);
        }

        public static void SetSceneFilePath(this LocationDefinition definition, String value)
        {
            definition.SetField("sceneFilePath", value);
        }

        public static void SetSceneReference(this LocationDefinition definition, AssetReference value)
        {
            definition.SetField("sceneReference", value);
        }

        public static void SetSetCurrentCampaignNodeWhenLeaving(this LocationDefinition definition, Boolean value)
        {
            definition.SetField("setCurrentCampaignNodeWhenLeaving", value);
        }

        public static void SetStartsWithScavengerCamp(this LocationDefinition definition, Boolean value)
        {
            definition.SetField("startsWithScavengerCamp", value);
        }
    }
}