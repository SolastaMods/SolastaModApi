using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
    public static class GuiTooltipClassDefinitionExtensions
    {
        public static T SetPanelWidth<T>(this T definition, float value)
            where T : GuiTooltipClassDefinition
        {
            definition.SetField("panelWidth", value);
            return definition;
        }

        public static T SetShowDelay<T>(this T definition, float value)
            where T : GuiTooltipClassDefinition
        {
            definition.SetField("showDelay", value);
            return definition;
        }

        public static T SetTooltipPanelPrefab<T>(this T definition, GameObject value)
            where T : GuiTooltipClassDefinition
        {
            definition.SetField("tooltipPanelPrefab", value);
            return definition;
        }
    }
}