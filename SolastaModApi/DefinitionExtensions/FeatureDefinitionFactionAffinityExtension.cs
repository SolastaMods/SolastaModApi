using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionFactionAffinityExtensions
    {
        public static void SetOperation(this FeatureDefinitionFactionAffinity definition, FactionOperationDescription value)
        {
            definition.SetField("operation", value);
        }
    }
}