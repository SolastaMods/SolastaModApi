using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class GuiItemPropertyExtensions
    {
        public static T SetItemProperty<T>(this T entity, RulesetItemProperty value)
            where T : GuiItemProperty
        {
            entity.SetField("itemProperty", value);
            return entity;
        }
    }
}