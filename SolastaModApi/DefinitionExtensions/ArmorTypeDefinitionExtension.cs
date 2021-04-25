using SolastaModApi.Infrastructure;
using System;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ArmorTypeDefinitionExtensions
    {
        public static void SetArmorCategory(this ArmorTypeDefinition definition, String value)
        {
            definition.SetField("armorCategory", value);
        }

        public static void SetRequiresProficiency(this ArmorTypeDefinition definition, Boolean value)
        {
            definition.SetField("requiresProficiency", value);
        }

        public static void SetSoundEffectDescription(this ArmorTypeDefinition definition, SoundEffectDescription value)
        {
            definition.SetField("soundEffectDescription", value);
        }
    }
}