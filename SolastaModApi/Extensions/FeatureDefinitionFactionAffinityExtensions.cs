using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionFactionAffinityExtensions
    {
        public static T SetOperation<T>(this T entity, FactionOperationDescription value)
            where T : FeatureDefinitionFactionAffinity
        {
            entity.SetField("operation", value);
            return entity;
        }
    }
}