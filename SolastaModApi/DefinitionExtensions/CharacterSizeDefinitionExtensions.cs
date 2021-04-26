using SolastaModApi.Infrastructure;
using TA;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class CharacterSizeDefinitionExtensions
    {
        public static T SetBestiaryScaleFactor<T>(this T definition, float value)
            where T : CharacterSizeDefinition
        {
            definition.SetField("bestiaryScaleFactor", value);
            return definition;
        }

        public static T SetCarryingSize<T>(this T definition, CreatureSize value)
            where T : CharacterSizeDefinition
        {
            definition.SetField("carryingSize", value);
            return definition;
        }

        public static T SetMaxExtent<T>(this T definition, int3 value)
            where T : CharacterSizeDefinition
        {
            definition.SetField("maxExtent", value);
            return definition;
        }

        public static T SetMinExtent<T>(this T definition, int3 value)
            where T : CharacterSizeDefinition
        {
            definition.SetField("minExtent", value);
            return definition;
        }

        public static T SetVisionHeightFactor<T>(this T definition, float value)
            where T : CharacterSizeDefinition
        {
            definition.SetField("visionHeightFactor", value);
            return definition;
        }

        public static T SetWieldingSize<T>(this T definition, CreatureSize value)
            where T : CharacterSizeDefinition
        {
            definition.SetField("wieldingSize", value);
            return definition;
        }
    }
}