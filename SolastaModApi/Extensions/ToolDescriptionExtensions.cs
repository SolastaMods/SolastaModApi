using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class ToolDescriptionExtensions
    {
        public static T SetToolType<T>(this T entity, string value)
            where T : ToolDescription
        {
            entity.SetField("toolType", value);
            return entity;
        }
    }
}