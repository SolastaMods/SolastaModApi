using SolastaModApi.Infrastructure;
using static GameCampaignDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class NamedPlaceDefinitionExtensions
    {
        public static void SetNamedPlaceType(this NamedPlaceDefinition definition, NamedPlaceType value)
        {
            definition.SetField("namedPlaceType", value);
        }
    }
}