using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class WieldingConfigurationDescriptionExtensions
    {
        public static WieldingConfigurationDescription SetAnimationTag(this WieldingConfigurationDescription definition, string value)
        {
            definition.SetField("animationTag", value);
            return definition;
        }

        public static WieldingConfigurationDescription SetSecondaryAnimationTag(this WieldingConfigurationDescription definition, string value)
        {
            definition.SetField("secondaryAnimationTag", value);
            return definition;
        }

        public static WieldingConfigurationDescription SetSoundEffectDescription(this WieldingConfigurationDescription definition, SoundEffectDescription value)
        {
            definition.SetField("soundEffectDescription", value);
            return definition;
        }

        public static WieldingConfigurationDescription SetWeaponCategory(this WieldingConfigurationDescription definition, string value)
        {
            definition.SetField("weaponCategory", value);
            return definition;
        }

        public static WieldingConfigurationDescription SetWeaponProximity(this WieldingConfigurationDescription definition, AttackProximity value)
        {
            definition.SetField("weaponProximity", value);
            return definition;
        }
    }
}