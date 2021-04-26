using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using System.Collections.Generic;
using static CampaignDefinition;

namespace SolastaModApi
{
    public static class CampaignDefinitionExtensions
    {
        public static T SetAutoGameplayRoles<T>(this T definition, List<GameplayRoleFilter> value)
            where T : CampaignDefinition
        {
            definition.SetField("autoGameplayRoles", value);
            return definition;
        }

        public static T SetCalendar<T>(this T definition, CalendarDefinition value)
            where T : CampaignDefinition
        {
            definition.SetField("calendar", value);
            return definition;
        }

        public static T SetEditorOnly<T>(this T definition, bool value)
            where T : CampaignDefinition
        {
            definition.SetField("editorOnly", value);
            return definition;
        }

        public static T SetGraphicsCampaignMapReference<T>(this T definition, AssetReference value)
            where T : CampaignDefinition
        {
            definition.SetField("graphicsCampaignMapReference", value);
            return definition;
        }

        public static T SetInitialBestiaryContent<T>(this T definition, List<MonsterKnowledgeDescription> value)
            where T : CampaignDefinition
        {
            definition.SetField("initialBestiaryContent", value);
            return definition;
        }

        public static T SetInitialPartyPosition<T>(this T definition, string value)
            where T : CampaignDefinition
        {
            definition.SetField("initialPartyPosition", value);
            return definition;
        }

        public static T SetInsideLocation<T>(this T definition, string value)
            where T : CampaignDefinition
        {
            definition.SetField("insideLocation", value);
            return definition;
        }

        public static T SetIntroductionCaptions<T>(this T definition, List<string> value)
            where T : CampaignDefinition
        {
            definition.SetField("introductionCaptions", value);
            return definition;
        }

        public static T SetIntroMovieDefinition<T>(this T definition, MoviePlaybackDefinition value)
            where T : CampaignDefinition
        {
            definition.SetField("introMovieDefinition", value);
            return definition;
        }

        public static T SetIsUserCampaign<T>(this T definition, bool value)
            where T : CampaignDefinition
        {
            definition.SetField("isUserCampaign", value);
            return definition;
        }

        public static T SetJournalStart<T>(this T definition, string value)
            where T : CampaignDefinition
        {
            definition.SetField("journalStart", value);
            return definition;
        }

        public static T SetKnownRecipes<T>(this T definition, List<RecipeDefinition> value)
            where T : CampaignDefinition
        {
            definition.SetField("knownRecipes", value);
            return definition;
        }

        public static T SetMaxLevel<T>(this T definition, int value)
            where T : CampaignDefinition
        {
            definition.SetField("maxLevel", value);
            return definition;
        }

        public static T SetMinLevel<T>(this T definition, int value)
            where T : CampaignDefinition
        {
            definition.SetField("minLevel", value);
            return definition;
        }

        public static T SetPartySize<T>(this T definition, int value)
            where T : CampaignDefinition
        {
            definition.SetField("partySize", value);
            return definition;
        }

        public static T SetPredefinedParty<T>(this T definition, List<string> value)
            where T : CampaignDefinition
        {
            definition.SetField("predefinedParty", value);
            return definition;
        }

        public static T SetRegisteredFactions<T>(this T definition, List<FactionRegistration> value)
            where T : CampaignDefinition
        {
            definition.SetField("registeredFactions", value);
            return definition;
        }

        public static T SetRegisteredVariables<T>(this T definition, List<VariableRegistrationDescription> value)
            where T : CampaignDefinition
        {
            definition.SetField("registeredVariables", value);
            return definition;
        }

        public static T SetRenderSettingsSceneProfile<T>(this T definition, RenderSettingsSceneProfile value)
            where T : CampaignDefinition
        {
            definition.SetField("renderSettingsSceneProfile", value);
            return definition;
        }

        public static T SetSceneFilePath<T>(this T definition, string value)
            where T : CampaignDefinition
        {
            definition.SetField("sceneFilePath", value);
            return definition;
        }

        public static T SetSceneReference<T>(this T definition, AssetReference value)
            where T : CampaignDefinition
        {
            definition.SetField("sceneReference", value);
            return definition;
        }

        public static T SetStartDay<T>(this T definition, int value)
            where T : CampaignDefinition
        {
            definition.SetField("startDay", value);
            return definition;
        }

        public static T SetStartHour<T>(this T definition, int value)
            where T : CampaignDefinition
        {
            definition.SetField("startHour", value);
            return definition;
        }

        public static T SetStartingQuests<T>(this T definition, List<QuestTreeDefinition> value)
            where T : CampaignDefinition
        {
            definition.SetField("startingQuests", value);
            return definition;
        }

        public static T SetStartMonth<T>(this T definition, int value)
            where T : CampaignDefinition
        {
            definition.SetField("startMonth", value);
            return definition;
        }

        public static T SetStartYear<T>(this T definition, int value)
            where T : CampaignDefinition
        {
            definition.SetField("startYear", value);
            return definition;
        }
    }
}