using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    public static class CampaignNodeTypeDefinitionExtensions
    {
        public static T SetGraphicsCampaignNodeReference<T>(this T entity, AssetReference value)
            where T : CampaignNodeTypeDefinition
        {
            entity.SetField("graphicsCampaignNodeReference", value);
            return entity;
        }
    }
}