using SolastaModApi.Infrastructure;
using TA;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class CharacterSizeDefinitionExtensions
    {
        public static T SetBestiaryScaleFactor<T>(this T entity, float value)
            where T : CharacterSizeDefinition
        {
            entity.SetField("bestiaryScaleFactor", value);
            return entity;
        }

        public static T SetCarryingSize<T>(this T entity, CreatureSize value)
            where T : CharacterSizeDefinition
        {
            entity.SetField("carryingSize", value);
            return entity;
        }

        public static T SetMaxExtent<T>(this T entity, int3 value)
            where T : CharacterSizeDefinition
        {
            entity.SetField("maxExtent", value);
            return entity;
        }

        public static T SetMinExtent<T>(this T entity, int3 value)
            where T : CharacterSizeDefinition
        {
            entity.SetField("minExtent", value);
            return entity;
        }

        public static T SetVisionHeightFactor<T>(this T entity, float value)
            where T : CharacterSizeDefinition
        {
            entity.SetField("visionHeightFactor", value);
            return entity;
        }

        public static T SetWieldingSize<T>(this T entity, CreatureSize value)
            where T : CharacterSizeDefinition
        {
            entity.SetField("wieldingSize", value);
            return entity;
        }
    }
}