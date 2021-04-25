using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using System;
using System.Collections.Generic;
using static CampaignDefinition;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CampaignDefinitionExtensions
    {
        public static void SetAutoGameplayRoles(this CampaignDefinition definition, List<GameplayRoleFilter> value)
        {
            definition.SetField("autoGameplayRoles", value);
        }

        public static void SetCalendar(this CampaignDefinition definition, CalendarDefinition value)
        {
            definition.SetField("calendar", value);
        }

        public static void SetEditorOnly(this CampaignDefinition definition, Boolean value)
        {
            definition.SetField("editorOnly", value);
        }

        public static void SetGraphicsCampaignMapReference(this CampaignDefinition definition, AssetReference value)
        {
            definition.SetField("graphicsCampaignMapReference", value);
        }

        public static void SetInitialBestiaryContent(this CampaignDefinition definition, List<MonsterKnowledgeDescription> value)
        {
            definition.SetField("initialBestiaryContent", value);
        }

        public static void SetInitialPartyPosition(this CampaignDefinition definition, String value)
        {
            definition.SetField("initialPartyPosition", value);
        }

        public static void SetInsideLocation(this CampaignDefinition definition, String value)
        {
            definition.SetField("insideLocation", value);
        }

        public static void SetIntroductionCaptions(this CampaignDefinition definition, List<String> value)
        {
            definition.SetField("introductionCaptions", value);
        }

        public static void SetIntroMovieDefinition(this CampaignDefinition definition, MoviePlaybackDefinition value)
        {
            definition.SetField("introMovieDefinition", value);
        }

        public static void SetIsUserCampaign(this CampaignDefinition definition, Boolean value)
        {
            definition.SetField("isUserCampaign", value);
        }

        public static void SetJournalStart(this CampaignDefinition definition, String value)
        {
            definition.SetField("journalStart", value);
        }

        public static void SetKnownRecipes(this CampaignDefinition definition, List<RecipeDefinition> value)
        {
            definition.SetField("knownRecipes", value);
        }

        public static void SetMaxLevel(this CampaignDefinition definition, Int32 value)
        {
            definition.SetField("maxLevel", value);
        }

        public static void SetMinLevel(this CampaignDefinition definition, Int32 value)
        {
            definition.SetField("minLevel", value);
        }

        public static void SetPartySize(this CampaignDefinition definition, Int32 value)
        {
            definition.SetField("partySize", value);
        }

        public static void SetPredefinedParty(this CampaignDefinition definition, List<String> value)
        {
            definition.SetField("predefinedParty", value);
        }

        public static void SetRegisteredFactions(this CampaignDefinition definition, List<FactionRegistration> value)
        {
            definition.SetField("registeredFactions", value);
        }

        public static void SetRegisteredVariables(this CampaignDefinition definition, List<VariableRegistrationDescription> value)
        {
            definition.SetField("registeredVariables", value);
        }

        public static void SetRenderSettingsSceneProfile(this CampaignDefinition definition, RenderSettingsSceneProfile value)
        {
            definition.SetField("renderSettingsSceneProfile", value);
        }

        public static void SetSceneFilePath(this CampaignDefinition definition, String value)
        {
            definition.SetField("sceneFilePath", value);
        }

        public static void SetSceneReference(this CampaignDefinition definition, AssetReference value)
        {
            definition.SetField("sceneReference", value);
        }

        public static void SetStartDay(this CampaignDefinition definition, Int32 value)
        {
            definition.SetField("startDay", value);
        }

        public static void SetStartHour(this CampaignDefinition definition, Int32 value)
        {
            definition.SetField("startHour", value);
        }

        public static void SetStartingQuests(this CampaignDefinition definition, List<QuestTreeDefinition> value)
        {
            definition.SetField("startingQuests", value);
        }

        public static void SetStartMonth(this CampaignDefinition definition, Int32 value)
        {
            definition.SetField("startMonth", value);
        }

        public static void SetStartYear(this CampaignDefinition definition, Int32 value)
        {
            definition.SetField("startYear", value);
        }
    }
}