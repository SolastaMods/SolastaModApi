using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class StarterPackDescriptionExtensions
    {
        public static T SetContainerItem<T>(this T entity, string value)
            where T : StarterPackDescription
        {
            entity.SetField("containerItem", value);
            return entity;
        }
    }
}