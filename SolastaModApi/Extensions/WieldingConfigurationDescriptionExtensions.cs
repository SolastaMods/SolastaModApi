using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 0.5.24.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    public static class WieldingConfigurationDescriptionExtensions
    {
        public static T SetAnimationTag<T>(this T entity, string value)
            where T : WieldingConfigurationDescription
        {
            entity.SetField("animationTag", value);
            return entity;
        }

        public static T SetSecondaryAnimationTag<T>(this T entity, string value)
            where T : WieldingConfigurationDescription
        {
            entity.SetField("secondaryAnimationTag", value);
            return entity;
        }

        public static T SetSoundEffectDescription<T>(this T entity, SoundEffectDescription value)
            where T : WieldingConfigurationDescription
        {
            entity.SetField("soundEffectDescription", value);
            return entity;
        }

        public static T SetWeaponCategory<T>(this T entity, string value)
            where T : WieldingConfigurationDescription
        {
            entity.SetField("weaponCategory", value);
            return entity;
        }

        public static T SetWeaponProximity<T>(this T entity, AttackProximity value)
            where T : WieldingConfigurationDescription
        {
            entity.SetField("weaponProximity", value);
            return entity;
        }
    }
}