using SolastaModApi.Infrastructure;
using static GameCampaignDefinitions;

namespace SolastaModApi
{
    public static class NamedPlaceDefinitionExtensions
    {
        public static T SetNamedPlaceType<T>(this T definition, NamedPlaceType value)
            where T : NamedPlaceDefinition
        {
            definition.SetField("namedPlaceType", value);
            return definition;
        }
    }
}