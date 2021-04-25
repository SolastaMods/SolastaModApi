using SolastaModApi.Infrastructure;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ArmorTypeDefinitionExtensions
    {
        public static ArmorTypeDefinition SetArmorCategory(this ArmorTypeDefinition definition, string value)
        {
            definition.SetField("armorCategory", value);
            return definition;
        }

        public static ArmorTypeDefinition SetRequiresProficiency(this ArmorTypeDefinition definition, bool value)
        {
            definition.SetField("requiresProficiency", value);
            return definition;
        }

        public static ArmorTypeDefinition SetSoundEffectDescription(this ArmorTypeDefinition definition, SoundEffectDescription value)
        {
            definition.SetField("soundEffectDescription", value);
            return definition;
        }
    }
}