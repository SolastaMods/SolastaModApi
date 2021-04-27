using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    public static class CampaignDefinitionExtensions
    {
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