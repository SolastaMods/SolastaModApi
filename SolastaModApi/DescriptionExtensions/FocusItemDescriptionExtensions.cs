using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FocusItemDescriptionExtensions
    {
        public static T SetFocusType<T>(this T entity, EquipmentDefinitions.FocusType value)
            where T : FocusItemDescription
        {
            entity.SetField("focusType", value);
            return entity;
        }

        public static T SetShownAsFocus<T>(this T entity, bool value)
            where T : FocusItemDescription
        {
            entity.SetField("shownAsFocus", value);
            return entity;
        }
    }
}