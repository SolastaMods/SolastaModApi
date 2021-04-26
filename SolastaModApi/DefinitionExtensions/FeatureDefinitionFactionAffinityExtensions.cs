using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionFactionAffinityExtensions
    {
        public static T SetOperation<T>(this T definition, FactionOperationDescription value)
            where T : FeatureDefinitionFactionAffinity
        {
            definition.SetField("operation", value);
            return definition;
        }
    }
}