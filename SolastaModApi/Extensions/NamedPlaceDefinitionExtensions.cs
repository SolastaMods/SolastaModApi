using SolastaModApi.Infrastructure;
using static GameCampaignDefinitions;

namespace SolastaModApi
{
    public static class NamedPlaceDefinitionExtensions
    {
        public static T SetNamedPlaceType<T>(this T entity, NamedPlaceType value)
            where T : NamedPlaceDefinition
        {
            entity.SetField("namedPlaceType", value);
            return entity;
        }
    }
}