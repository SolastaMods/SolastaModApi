using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionLightSourceExtensions
    {
        public static T SetLightSourceForm<T>(this T definition, LightSourceForm value)
            where T : FeatureDefinitionLightSource
        {
            definition.SetField("lightSourceForm", value);
            return definition;
        }
    }
}