using SolastaModApi.Infrastructure;
using UnityEngine;
using System.Collections.Generic;
using static TooltipDefinitions;

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

        public static T SetTooltipFeatures<T>(this T definition, List<FeatureInfo> value)
            where T : GuiTooltipClassDefinition
        {
            definition.SetField("tooltipFeatures", value);
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