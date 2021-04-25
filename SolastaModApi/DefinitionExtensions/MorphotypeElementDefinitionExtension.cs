using SolastaModApi.Infrastructure;
using UnityEngine;
using TA;
using static MorphotypeElementDefinition;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class MorphotypeElementDefinitionExtensions
    {
        public static MorphotypeElementDefinition SetCategory(this MorphotypeElementDefinition definition, ElementCategory value)
        {
            definition.SetField("category", value);
            return definition;
        }

        public static MorphotypeElementDefinition SetMainColor(this MorphotypeElementDefinition definition, Color value)
        {
            definition.SetField("mainColor", value);
            return definition;
        }

        public static MorphotypeElementDefinition SetMinMaxValue(this MorphotypeElementDefinition definition, RangedFloat value)
        {
            definition.SetField("minMaxValue", value);
            return definition;
        }

        public static MorphotypeElementDefinition SetOriginAllowed(this MorphotypeElementDefinition definition, string[] value)
        {
            definition.SetField("originAllowed", value);
            return definition;
        }

        public static MorphotypeElementDefinition SetPlayerSelectable(this MorphotypeElementDefinition definition, bool value)
        {
            definition.SetField("playerSelectable", value);
            return definition;
        }

        public static MorphotypeElementDefinition SetSecondColor(this MorphotypeElementDefinition definition, Color value)
        {
            definition.SetField("secondColor", value);
            return definition;
        }

        public static MorphotypeElementDefinition SetThirdColor(this MorphotypeElementDefinition definition, Color value)
        {
            definition.SetField("thirdColor", value);
            return definition;
        }
    }
}