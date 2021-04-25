using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using System.Collections.Generic;
using static CampaignDefinition;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CampaignDefinitionExtensions
    {
        public static CampaignDefinition SetAutoGameplayRoles(this CampaignDefinition definition, List<GameplayRoleFilter> value)
        {
            definition.SetField("autoGameplayRoles", value);
            return definition;
        }

        public static CampaignDefinition SetCalendar(this CampaignDefinition definition, CalendarDefinition value)
        {
            definition.SetField("calendar", value);
            return definition;
        }

        public static CampaignDefinition SetEditorOnly(this CampaignDefinition definition, bool value)
        {
            definition.SetField("editorOnly", value);
            return definition;
        }

        public static CampaignDefinition SetGraphicsCampaignMapReference(this CampaignDefinition definition, AssetReference value)
        {
            definition.SetField("graphicsCampaignMapReference", value);
            return definition;
        }

        public static CampaignDefinition SetInitialBestiaryContent(this CampaignDefinition definition, List<MonsterKnowledgeDescription> value)
        {
            definition.SetField("initialBestiaryContent", value);
            return definition;
        }

        public static CampaignDefinition SetInitialPartyPosition(this CampaignDefinition definition, string value)
        {
            definition.SetField("initialPartyPosition", value);
            return definition;
        }

        public static CampaignDefinition SetInsideLocation(this CampaignDefinition definition, string value)
        {
            definition.SetField("insideLocation", value);
            return definition;
        }

        public static CampaignDefinition SetIntroductionCaptions(this CampaignDefinition definition, List<string> value)
        {
            definition.SetField("introductionCaptions", value);
            return definition;
        }

        public static CampaignDefinition SetIntroMovieDefinition(this CampaignDefinition definition, MoviePlaybackDefinition value)
        {
            definition.SetField("introMovieDefinition", value);
            return definition;
        }

        public static CampaignDefinition SetIsUserCampaign(this CampaignDefinition definition, bool value)
        {
            definition.SetField("isUserCampaign", value);
            return definition;
        }

        public static CampaignDefinition SetJournalStart(this CampaignDefinition definition, string value)
        {
            definition.SetField("journalStart", value);
            return definition;
        }

        public static CampaignDefinition SetKnownRecipes(this CampaignDefinition definition, List<RecipeDefinition> value)
        {
            definition.SetField("knownRecipes", value);
            return definition;
        }

        public static CampaignDefinition SetMaxLevel(this CampaignDefinition definition, int value)
        {
            definition.SetField("maxLevel", value);
            return definition;
        }

        public static CampaignDefinition SetMinLevel(this CampaignDefinition definition, int value)
        {
            definition.SetField("minLevel", value);
            return definition;
        }

        public static CampaignDefinition SetPartySize(this CampaignDefinition definition, int value)
        {
            definition.SetField("partySize", value);
            return definition;
        }

        public static CampaignDefinition SetPredefinedParty(this CampaignDefinition definition, List<string> value)
        {
            definition.SetField("predefinedParty", value);
            return definition;
        }

        public static CampaignDefinition SetRegisteredFactions(this CampaignDefinition definition, List<FactionRegistration> value)
        {
            definition.SetField("registeredFactions", value);
            return definition;
        }

        public static CampaignDefinition SetRegisteredVariables(this CampaignDefinition definition, List<VariableRegistrationDescription> value)
        {
            definition.SetField("registeredVariables", value);
            return definition;
        }

        public static CampaignDefinition SetRenderSettingsSceneProfile(this CampaignDefinition definition, RenderSettingsSceneProfile value)
        {
            definition.SetField("renderSettingsSceneProfile", value);
            return definition;
        }

        public static CampaignDefinition SetSceneFilePath(this CampaignDefinition definition, string value)
        {
            definition.SetField("sceneFilePath", value);
            return definition;
        }

        public static CampaignDefinition SetSceneReference(this CampaignDefinition definition, AssetReference value)
        {
            definition.SetField("sceneReference", value);
            return definition;
        }

        public static CampaignDefinition SetStartDay(this CampaignDefinition definition, int value)
        {
            definition.SetField("startDay", value);
            return definition;
        }

        public static CampaignDefinition SetStartHour(this CampaignDefinition definition, int value)
        {
            definition.SetField("startHour", value);
            return definition;
        }

        public static CampaignDefinition SetStartingQuests(this CampaignDefinition definition, List<QuestTreeDefinition> value)
        {
            definition.SetField("startingQuests", value);
            return definition;
        }

        public static CampaignDefinition SetStartMonth(this CampaignDefinition definition, int value)
        {
            definition.SetField("startMonth", value);
            return definition;
        }

        public static CampaignDefinition SetStartYear(this CampaignDefinition definition, int value)
        {
            definition.SetField("startYear", value);
            return definition;
        }
    }
}