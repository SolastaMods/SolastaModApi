using SolastaModApi.Infrastructure;
using TA;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CharacterSizeDefinitionExtensions
    {
        public static CharacterSizeDefinition SetBestiaryScaleFactor(this CharacterSizeDefinition definition, float value)
        {
            definition.SetField("bestiaryScaleFactor", value);
            return definition;
        }

        public static CharacterSizeDefinition SetCarryingSize(this CharacterSizeDefinition definition, CreatureSize value)
        {
            definition.SetField("carryingSize", value);
            return definition;
        }

        public static CharacterSizeDefinition SetMaxExtent(this CharacterSizeDefinition definition, int3 value)
        {
            definition.SetField("maxExtent", value);
            return definition;
        }

        public static CharacterSizeDefinition SetMinExtent(this CharacterSizeDefinition definition, int3 value)
        {
            definition.SetField("minExtent", value);
            return definition;
        }

        public static CharacterSizeDefinition SetVisionHeightFactor(this CharacterSizeDefinition definition, float value)
        {
            definition.SetField("visionHeightFactor", value);
            return definition;
        }

        public static CharacterSizeDefinition SetWieldingSize(this CharacterSizeDefinition definition, CreatureSize value)
        {
            definition.SetField("wieldingSize", value);
            return definition;
        }
    }
}