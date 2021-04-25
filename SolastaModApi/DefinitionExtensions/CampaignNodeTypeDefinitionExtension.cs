using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CampaignNodeTypeDefinitionExtensions
    {
        public static void SetGraphicsCampaignNodeReference(this CampaignNodeTypeDefinition definition, AssetReference value)
        {
            definition.SetField("graphicsCampaignNodeReference", value);
        }
    }
}