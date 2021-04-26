using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class BaseDefinitionExtensions
    {
        public static T SetCachedName<T>(this T definition, string value)
            where T : BaseDefinition
        {
            definition.SetField("cachedName", value);
            return definition;
        }

        public static T SetContentCopyright<T>(this T definition, BaseDefinition.Copyright value)
            where T : BaseDefinition
        {
            definition.SetField("contentCopyright", value);
            return definition;
        }

        public static T SetGuid<T>(this T definition, string value)
            where T : BaseDefinition
        {
            definition.SetField("guid", value);
            return definition;
        }

        public static T SetGuiPresentation<T>(this T definition, GuiPresentation value)
            where T : BaseDefinition
        {
            definition.SetField("guiPresentation", value);
            return definition;
        }
    }
}