using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionMoveThroughEnemyModifierExtensions
    {
        public static T SetMinSizeDifference<T>(this T entity, int value)
            where T : FeatureDefinitionMoveThroughEnemyModifier
        {
            entity.SetField("minSizeDifference", value);
            return entity;
        }
    }
}