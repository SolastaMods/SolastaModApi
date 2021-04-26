using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;

namespace SolastaModApi
{
    public static class CampaignNodeTypeDefinitionExtensions
    {
        public static T SetGraphicsCampaignNodeReference<T>(this T definition, AssetReference value)
            where T : CampaignNodeTypeDefinition
        {
            definition.SetField("graphicsCampaignNodeReference", value);
            return definition;
        }
    }
}