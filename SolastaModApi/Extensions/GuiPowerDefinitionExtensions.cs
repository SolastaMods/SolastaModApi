using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated against Solasta 1.0.12.
    /// Not guaranteed to work against any other version of Solasta.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(GuiPowerDefinition))]
    public static class GuiPowerDefinitionExtensions
    {
        public static T SetPowerDefinition<T>(this T entity, FeatureDefinitionPower value)
            where T : GuiPowerDefinition
        {
            entity.SetField("<PowerDefinition>k__BackingField", value);
            return entity;
        }
    }
}