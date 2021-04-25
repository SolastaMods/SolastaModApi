using SolastaModApi.Infrastructure;
using System;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class WieldingConfigurationDescriptionExtensions
    {
        public static void SetAnimationTag(this WieldingConfigurationDescription definition, String value)
        {
            definition.SetField("animationTag", value);
        }

        public static void SetSecondaryAnimationTag(this WieldingConfigurationDescription definition, String value)
        {
            definition.SetField("secondaryAnimationTag", value);
        }

        public static void SetSoundEffectDescription(this WieldingConfigurationDescription definition, SoundEffectDescription value)
        {
            definition.SetField("soundEffectDescription", value);
        }

        public static void SetWeaponCategory(this WieldingConfigurationDescription definition, String value)
        {
            definition.SetField("weaponCategory", value);
        }

        public static void SetWeaponProximity(this WieldingConfigurationDescription definition, AttackProximity value)
        {
            definition.SetField("weaponProximity", value);
        }
    }
}