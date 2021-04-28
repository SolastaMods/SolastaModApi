using SolastaModApi.Infrastructure;
using UnityEngine;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class LightSourceItemDescriptionExtensions
    {
        public static T SetActiveSpriteReference<T>(this T entity, AssetReferenceSprite value)
            where T : LightSourceItemDescription
        {
            entity.SetField("activeSpriteReference", value);
            return entity;
        }

        public static T SetBrightRange<T>(this T entity, int value)
            where T : LightSourceItemDescription
        {
            entity.SetField("brightRange", value);
            return entity;
        }

        public static T SetColor<T>(this T entity, Color value)
            where T : LightSourceItemDescription
        {
            entity.SetField("color", value);
            return entity;
        }

        public static T SetDimAdditionalRange<T>(this T entity, int value)
            where T : LightSourceItemDescription
        {
            entity.SetField("dimAdditionalRange", value);
            return entity;
        }

        public static T SetDurationType<T>(this T entity, DurationType value)
            where T : LightSourceItemDescription
        {
            entity.SetField("durationType", value);
            return entity;
        }

        public static T SetDurationValue<T>(this T entity, int value)
            where T : LightSourceItemDescription
        {
            entity.SetField("durationValue", value);
            return entity;
        }

        public static T SetLightSourceType<T>(this T entity, LightSourceType value)
            where T : LightSourceItemDescription
        {
            entity.SetField("lightSourceType", value);
            return entity;
        }
    }
}