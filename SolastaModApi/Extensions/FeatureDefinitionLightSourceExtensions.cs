using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionLightSourceExtensions
    {
        public static T SetLightSourceForm<T>(this T entity, LightSourceForm value)
            where T : FeatureDefinitionLightSource
        {
            entity.SetField("lightSourceForm", value);
            return entity;
        }
    }
}