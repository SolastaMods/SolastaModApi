using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class ArmorTypeDefinitionExtensions
    {
        public static T SetArmorCategory<T>(this T definition, string value)
            where T : ArmorTypeDefinition
        {
            definition.SetField("armorCategory", value);
            return definition;
        }

        public static T SetRequiresProficiency<T>(this T definition, bool value)
            where T : ArmorTypeDefinition
        {
            definition.SetField("requiresProficiency", value);
            return definition;
        }

        public static T SetSoundEffectDescription<T>(this T definition, SoundEffectDescription value)
            where T : ArmorTypeDefinition
        {
            definition.SetField("soundEffectDescription", value);
            return definition;
        }
    }
}