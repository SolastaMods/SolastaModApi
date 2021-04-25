using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CampaignNodeTypeDefinitionExtensions
    {
        public static CampaignNodeTypeDefinition SetGraphicsCampaignNodeReference(this CampaignNodeTypeDefinition definition, AssetReference value)
        {
            definition.SetField("graphicsCampaignNodeReference", value);
            return definition;
        }
    }
}