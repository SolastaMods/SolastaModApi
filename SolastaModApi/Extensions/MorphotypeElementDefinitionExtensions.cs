using SolastaModApi.Infrastructure;
using UnityEngine;
using TA;
using static MorphotypeElementDefinition;

namespace SolastaModApi
{
    public static class MorphotypeElementDefinitionExtensions
    {
        public static T SetCategory<T>(this T entity, ElementCategory value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("category", value);
            return entity;
        }

        public static T SetMainColor<T>(this T entity, Color value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("mainColor", value);
            return entity;
        }

        public static T SetMinMaxValue<T>(this T entity, RangedFloat value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("minMaxValue", value);
            return entity;
        }

        public static T SetOriginAllowed<T>(this T entity, string[] value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("originAllowed", value);
            return entity;
        }

        public static T SetPlayerSelectable<T>(this T entity, bool value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("playerSelectable", value);
            return entity;
        }

        public static T SetSecondColor<T>(this T entity, Color value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("secondColor", value);
            return entity;
        }

        public static T SetThirdColor<T>(this T entity, Color value)
            where T : MorphotypeElementDefinition
        {
            entity.SetField("thirdColor", value);
            return entity;
        }
    }
}