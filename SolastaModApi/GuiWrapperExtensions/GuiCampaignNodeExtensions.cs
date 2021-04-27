using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class GuiCampaignNodeExtensions
    {
        public static T SetGameCampaignNode<T>(this T entity, GameCampaignNode value)
            where T : GuiCampaignNode
        {
            entity.SetField("gameCampaignNode", value);
            return entity;
        }

        public static T SetListing<T>(this T entity, string value)
            where T : GuiCampaignNode
        {
            entity.SetField("listing", value);
            return entity;
        }
    }
}