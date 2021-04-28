using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class ArmorTypeDefinitionExtensions
    {
        public static T SetArmorCategory<T>(this T entity, string value)
            where T : ArmorTypeDefinition
        {
            entity.SetField("armorCategory", value);
            return entity;
        }

        public static T SetRequiresProficiency<T>(this T entity, bool value)
            where T : ArmorTypeDefinition
        {
            entity.SetField("requiresProficiency", value);
            return entity;
        }

        public static T SetSoundEffectDescription<T>(this T entity, SoundEffectDescription value)
            where T : ArmorTypeDefinition
        {
            entity.SetField("soundEffectDescription", value);
            return entity;
        }
    }
}