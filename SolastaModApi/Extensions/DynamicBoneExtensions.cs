using SolastaModApi.Infrastructure;
using UnityEngine;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class DynamicBoneExtensions
    {
        public static T SetBoneTotalLength<T>(this T entity, float value)
            where T : DynamicBone
        {
            entity.SetField("m_BoneTotalLength", value);
            return entity;
        }

        public static T SetDistantDisabled<T>(this T entity, bool value)
            where T : DynamicBone
        {
            entity.SetField("m_DistantDisabled", value);
            return entity;
        }

        public static T SetLocalGravity<T>(this T entity, Vector3 value)
            where T : DynamicBone
        {
            entity.SetField("m_LocalGravity", value);
            return entity;
        }

        public static T SetObjectMove<T>(this T entity, Vector3 value)
            where T : DynamicBone
        {
            entity.SetField("m_ObjectMove", value);
            return entity;
        }

        public static T SetObjectPrevPosition<T>(this T entity, Vector3 value)
            where T : DynamicBone
        {
            entity.SetField("m_ObjectPrevPosition", value);
            return entity;
        }

        public static T SetObjectScale<T>(this T entity, float value)
            where T : DynamicBone
        {
            entity.SetField("m_ObjectScale", value);
            return entity;
        }

        public static T SetTime<T>(this T entity, float value)
            where T : DynamicBone
        {
            entity.SetField("m_Time", value);
            return entity;
        }

        public static T SetWeight<T>(this T entity, float value)
            where T : DynamicBone
        {
            entity.SetField("m_Weight", value);
            return entity;
        }
    }
}