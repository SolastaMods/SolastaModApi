using SolastaModApi.Infrastructure;
using UnityEngine;
using System;
using TA;
using static MorphotypeElementDefinition;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MorphotypeElementDefinitionExtensions
    {
        public static void SetCategory(this MorphotypeElementDefinition definition, ElementCategory value)
        {
            definition.SetField("category", value);
        }

        public static void SetMainColor(this MorphotypeElementDefinition definition, Color value)
        {
            definition.SetField("mainColor", value);
        }

        public static void SetMinMaxValue(this MorphotypeElementDefinition definition, RangedFloat value)
        {
            definition.SetField("minMaxValue", value);
        }

        public static void SetOriginAllowed(this MorphotypeElementDefinition definition, String[] value)
        {
            definition.SetField("originAllowed", value);
        }

        public static void SetPlayerSelectable(this MorphotypeElementDefinition definition, Boolean value)
        {
            definition.SetField("playerSelectable", value);
        }

        public static void SetSecondColor(this MorphotypeElementDefinition definition, Color value)
        {
            definition.SetField("secondColor", value);
        }

        public static void SetThirdColor(this MorphotypeElementDefinition definition, Color value)
        {
            definition.SetField("thirdColor", value);
        }
    }
}