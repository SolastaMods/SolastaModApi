using SolastaModApi.Infrastructure;
using UnityEngine;
using TA;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class RulesetLightSourceExtensions
    {
        public static T SetBrightRange<T>(this T entity, float value)
            where T : RulesetLightSource
        {
            entity.SetField("brightRange", value);
            return entity;
        }

        public static T SetColor<T>(this T entity, Color value)
            where T : RulesetLightSource
        {
            entity.SetField("color", value);
            return entity;
        }

        public static T SetDayCycleType<T>(this T entity, LightSourceDayCycleType value)
            where T : RulesetLightSource
        {
            entity.SetField("dayCycleType", value);
            return entity;
        }

        public static T SetDimRange<T>(this T entity, float value)
            where T : RulesetLightSource
        {
            entity.SetField("dimRange", value);
            return entity;
        }

        public static T SetLightSourceType<T>(this T entity, LightSourceType value)
            where T : RulesetLightSource
        {
            entity.SetField("lightSourceType", value);
            return entity;
        }

        public static T SetSpecificLocationPosition<T>(this T entity, int3 value)
            where T : RulesetLightSource
        {
            entity.SetField("specificLocationPosition", value);
            return entity;
        }

        public static T SetSpotAngle<T>(this T entity, float value)
            where T : RulesetLightSource
        {
            entity.SetField("spotAngle", value);
            return entity;
        }

        public static T SetSpotDirection<T>(this T entity, Vector3 value)
            where T : RulesetLightSource
        {
            entity.SetField("spotDirection", value);
            return entity;
        }

        public static T SetTargetGuid<T>(this T entity, ulong value)
            where T : RulesetLightSource
        {
            entity.SetField("targetGuid", value);
            return entity;
        }

        public static T SetTargetItemGuid<T>(this T entity, ulong value)
            where T : RulesetLightSource
        {
            entity.SetField("targetItemGuid", value);
            return entity;
        }
    }
}