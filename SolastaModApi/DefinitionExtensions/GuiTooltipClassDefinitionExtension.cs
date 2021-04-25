using SolastaModApi.Infrastructure;
using UnityEngine;
using System;
using System.Collections.Generic;
using static TooltipDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class GuiTooltipClassDefinitionExtensions
    {
        public static void SetPanelWidth(this GuiTooltipClassDefinition definition, Single value)
        {
            definition.SetField("panelWidth", value);
        }

        public static void SetShowDelay(this GuiTooltipClassDefinition definition, Single value)
        {
            definition.SetField("showDelay", value);
        }

        public static void SetTooltipFeatures(this GuiTooltipClassDefinition definition, List<FeatureInfo> value)
        {
            definition.SetField("tooltipFeatures", value);
        }

        public static void SetTooltipPanelPrefab(this GuiTooltipClassDefinition definition, GameObject value)
        {
            definition.SetField("tooltipPanelPrefab", value);
        }
    }
}