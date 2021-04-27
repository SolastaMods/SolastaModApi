using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FightingStyleDefinitionExtensions
    {
        public static T SetCondition<T>(this T definition, FightingStyleDefinition.TriggerCondition value)
            where T : FightingStyleDefinition
        {
            definition.SetField("condition", value);
            return definition;
        }
    }
}