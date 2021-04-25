using SolastaModApi.Infrastructure;
using UnityEngine;
using System.Collections.Generic;
using static TooltipDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class GuiTooltipClassDefinitionExtensions
    {
        public static GuiTooltipClassDefinition SetPanelWidth(this GuiTooltipClassDefinition definition, float value)
        {
            definition.SetField("panelWidth", value);
            return definition;
        }

        public static GuiTooltipClassDefinition SetShowDelay(this GuiTooltipClassDefinition definition, float value)
        {
            definition.SetField("showDelay", value);
            return definition;
        }

        public static GuiTooltipClassDefinition SetTooltipFeatures(this GuiTooltipClassDefinition definition, List<FeatureInfo> value)
        {
            definition.SetField("tooltipFeatures", value);
            return definition;
        }

        public static GuiTooltipClassDefinition SetTooltipPanelPrefab(this GuiTooltipClassDefinition definition, GameObject value)
        {
            definition.SetField("tooltipPanelPrefab", value);
            return definition;
        }
    }
}