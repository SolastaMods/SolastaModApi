using SolastaModApi.Infrastructure;
using static GameCampaignDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class NamedPlaceDefinitionExtensions
    {
        public static NamedPlaceDefinition SetNamedPlaceType(this NamedPlaceDefinition definition, NamedPlaceType value)
        {
            definition.SetField("namedPlaceType", value);
            return definition;
        }
    }
}