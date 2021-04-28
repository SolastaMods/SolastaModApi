using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    public static class CampaignDefinitionExtensions
    {
        public static T SetCalendar<T>(this T entity, CalendarDefinition value)
            where T : CampaignDefinition
        {
            entity.SetField("calendar", value);
            return entity;
        }

        public static T SetEditorOnly<T>(this T entity, bool value)
            where T : CampaignDefinition
        {
            entity.SetField("editorOnly", value);
            return entity;
        }

        public static T SetGraphicsCampaignMapReference<T>(this T entity, AssetReference value)
            where T : CampaignDefinition
        {
            entity.SetField("graphicsCampaignMapReference", value);
            return entity;
        }

        public static T SetInitialPartyPosition<T>(this T entity, string value)
            where T : CampaignDefinition
        {
            entity.SetField("initialPartyPosition", value);
            return entity;
        }

        public static T SetInsideLocation<T>(this T entity, string value)
            where T : CampaignDefinition
        {
            entity.SetField("insideLocation", value);
            return entity;
        }

        public static T SetIntroMovieDefinition<T>(this T entity, MoviePlaybackDefinition value)
            where T : CampaignDefinition
        {
            entity.SetField("introMovieDefinition", value);
            return entity;
        }

        public static T SetIsUserCampaign<T>(this T entity, bool value)
            where T : CampaignDefinition
        {
            entity.SetField("isUserCampaign", value);
            return entity;
        }

        public static T SetJournalStart<T>(this T entity, string value)
            where T : CampaignDefinition
        {
            entity.SetField("journalStart", value);
            return entity;
        }

        public static T SetMaxLevel<T>(this T entity, int value)
            where T : CampaignDefinition
        {
            entity.SetField("maxLevel", value);
            return entity;
        }

        public static T SetMinLevel<T>(this T entity, int value)
            where T : CampaignDefinition
        {
            entity.SetField("minLevel", value);
            return entity;
        }

        public static T SetPartySize<T>(this T entity, int value)
            where T : CampaignDefinition
        {
            entity.SetField("partySize", value);
            return entity;
        }

        public static T SetRenderSettingsSceneProfile<T>(this T entity, RenderSettingsSceneProfile value)
            where T : CampaignDefinition
        {
            entity.SetField("renderSettingsSceneProfile", value);
            return entity;
        }

        public static T SetSceneFilePath<T>(this T entity, string value)
            where T : CampaignDefinition
        {
            entity.SetField("sceneFilePath", value);
            return entity;
        }

        public static T SetSceneReference<T>(this T entity, AssetReference value)
            where T : CampaignDefinition
        {
            entity.SetField("sceneReference", value);
            return entity;
        }

        public static T SetStartDay<T>(this T entity, int value)
            where T : CampaignDefinition
        {
            entity.SetField("startDay", value);
            return entity;
        }

        public static T SetStartHour<T>(this T entity, int value)
            where T : CampaignDefinition
        {
            entity.SetField("startHour", value);
            return entity;
        }

        public static T SetStartMonth<T>(this T entity, int value)
            where T : CampaignDefinition
        {
            entity.SetField("startMonth", value);
            return entity;
        }

        public static T SetStartYear<T>(this T entity, int value)
            where T : CampaignDefinition
        {
            entity.SetField("startYear", value);
            return entity;
        }
    }
}