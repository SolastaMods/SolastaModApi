using SolastaModApi.Infrastructure;
using UnityEngine;
using TA;
using static MorphotypeElementDefinition;

namespace SolastaModApi
{
    public static class MorphotypeElementDefinitionExtensions
    {
        public static T SetCategory<T>(this T definition, ElementCategory value)
            where T : MorphotypeElementDefinition
        {
            definition.SetField("category", value);
            return definition;
        }

        public static T SetMainColor<T>(this T definition, Color value)
            where T : MorphotypeElementDefinition
        {
            definition.SetField("mainColor", value);
            return definition;
        }

        public static T SetMinMaxValue<T>(this T definition, RangedFloat value)
            where T : MorphotypeElementDefinition
        {
            definition.SetField("minMaxValue", value);
            return definition;
        }

        public static T SetOriginAllowed<T>(this T definition, string[] value)
            where T : MorphotypeElementDefinition
        {
            definition.SetField("originAllowed", value);
            return definition;
        }

        public static T SetPlayerSelectable<T>(this T definition, bool value)
            where T : MorphotypeElementDefinition
        {
            definition.SetField("playerSelectable", value);
            return definition;
        }

        public static T SetSecondColor<T>(this T definition, Color value)
            where T : MorphotypeElementDefinition
        {
            definition.SetField("secondColor", value);
            return definition;
        }

        public static T SetThirdColor<T>(this T definition, Color value)
            where T : MorphotypeElementDefinition
        {
            definition.SetField("thirdColor", value);
            return definition;
        }
    }
}