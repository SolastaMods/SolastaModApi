using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
    public static class GuiTooltipClassDefinitionExtensions
    {
        public static T SetPanelWidth<T>(this T entity, float value)
            where T : GuiTooltipClassDefinition
        {
            entity.SetField("panelWidth", value);
            return entity;
        }

        public static T SetShowDelay<T>(this T entity, float value)
            where T : GuiTooltipClassDefinition
        {
            entity.SetField("showDelay", value);
            return entity;
        }

        public static T SetTooltipPanelPrefab<T>(this T entity, GameObject value)
            where T : GuiTooltipClassDefinition
        {
            entity.SetField("tooltipPanelPrefab", value);
            return entity;
        }
    }
}