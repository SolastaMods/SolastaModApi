using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionFactionAffinityExtensions
    {
        public static FeatureDefinitionFactionAffinity SetOperation(this FeatureDefinitionFactionAffinity definition, FactionOperationDescription value)
        {
            definition.SetField("operation", value);
            return definition;
        }
    }
}