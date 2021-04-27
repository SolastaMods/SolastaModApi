using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class AmmunitionDescriptionExtensions
    {
        public static T SetAmmunitionType<T>(this T entity, string value)
            where T : AmmunitionDescription
        {
            entity.SetField("ammunitionType", value);
            return entity;
        }

        public static T SetApplyCharacterScale<T>(this T entity, bool value)
            where T : AmmunitionDescription
        {
            entity.SetField("applyCharacterScale", value);
            return entity;
        }

        public static T SetEffectDescription<T>(this T entity, EffectDescription value)
            where T : AmmunitionDescription
        {
            entity.SetField("effectDescription", value);
            return entity;
        }
    }
}