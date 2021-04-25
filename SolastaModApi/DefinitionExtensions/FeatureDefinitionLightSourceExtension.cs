using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionLightSourceExtensions
    {
        public static FeatureDefinitionLightSource SetLightSourceForm(this FeatureDefinitionLightSource definition, LightSourceForm value)
        {
            definition.SetField("lightSourceForm", value);
            return definition;
        }
    }
}