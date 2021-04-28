using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class BaseDefinitionExtensions
    {
        public static T SetCachedName<T>(this T entity, string value)
            where T : BaseDefinition
        {
            entity.SetField("cachedName", value);
            return entity;
        }

        public static T SetContentCopyright<T>(this T entity, BaseDefinition.Copyright value)
            where T : BaseDefinition
        {
            entity.SetField("contentCopyright", value);
            return entity;
        }

        public static T SetGuid<T>(this T entity, string value)
            where T : BaseDefinition
        {
            entity.SetField("guid", value);
            return entity;
        }

        public static T SetGuiPresentation<T>(this T entity, GuiPresentation value)
            where T : BaseDefinition
        {
            entity.SetField("guiPresentation", value);
            return entity;
        }
    }
}