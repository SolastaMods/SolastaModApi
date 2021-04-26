using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class WieldingConfigurationDescriptionExtensions
    {
        public static T SetAnimationTag<T>(this T definition, string value)
            where T : WieldingConfigurationDescription
        {
            definition.SetField("animationTag", value);
            return definition;
        }

        public static T SetSecondaryAnimationTag<T>(this T definition, string value)
            where T : WieldingConfigurationDescription
        {
            definition.SetField("secondaryAnimationTag", value);
            return definition;
        }

        public static T SetSoundEffectDescription<T>(this T definition, SoundEffectDescription value)
            where T : WieldingConfigurationDescription
        {
            definition.SetField("soundEffectDescription", value);
            return definition;
        }

        public static T SetWeaponCategory<T>(this T definition, string value)
            where T : WieldingConfigurationDescription
        {
            definition.SetField("weaponCategory", value);
            return definition;
        }

        public static T SetWeaponProximity<T>(this T definition, AttackProximity value)
            where T : WieldingConfigurationDescription
        {
            definition.SetField("weaponProximity", value);
            return definition;
        }
    }
}