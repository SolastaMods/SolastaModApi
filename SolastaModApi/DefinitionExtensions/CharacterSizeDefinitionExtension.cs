using SolastaModApi.Infrastructure;
using System;
using TA;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CharacterSizeDefinitionExtensions
    {
        public static void SetBestiaryScaleFactor(this CharacterSizeDefinition definition, Single value)
        {
            definition.SetField("bestiaryScaleFactor", value);
        }

        public static void SetCarryingSize(this CharacterSizeDefinition definition, CreatureSize value)
        {
            definition.SetField("carryingSize", value);
        }

        public static void SetMaxExtent(this CharacterSizeDefinition definition, int3 value)
        {
            definition.SetField("maxExtent", value);
        }

        public static void SetMinExtent(this CharacterSizeDefinition definition, int3 value)
        {
            definition.SetField("minExtent", value);
        }

        public static void SetVisionHeightFactor(this CharacterSizeDefinition definition, Single value)
        {
            definition.SetField("visionHeightFactor", value);
        }

        public static void SetWieldingSize(this CharacterSizeDefinition definition, CreatureSize value)
        {
            definition.SetField("wieldingSize", value);
        }
    }
}