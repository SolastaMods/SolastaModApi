using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionMovementAffinityExtensions
    {
        public static T SetAdditionalFallThreshold<T>(this T entity, int value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("additionalFallThreshold", value);
            return entity;
        }

        public static T SetAdditionalJumpCells<T>(this T entity, int value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("additionalJumpCells", value);
            return entity;
        }

        public static T SetAppliesToAllModes<T>(this T entity, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("appliesToAllModes", value);
            return entity;
        }

        public static T SetBaseSpeedAdditiveModifier<T>(this T entity, int value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("baseSpeedAdditiveModifier", value);
            return entity;
        }

        public static T SetBaseSpeedMultiplicativeModifier<T>(this T entity, float value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("baseSpeedMultiplicativeModifier", value);
            return entity;
        }

        public static T SetCanMoveOnWalls<T>(this T entity, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("canMoveOnWalls", value);
            return entity;
        }

        public static T SetDisableClimb<T>(this T entity, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("disableClimb", value);
            return entity;
        }

        public static T SetDisableDrop<T>(this T entity, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("disableDrop", value);
            return entity;
        }

        public static T SetDisableJump<T>(this T entity, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("disableJump", value);
            return entity;
        }

        public static T SetDisableVault<T>(this T entity, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("disableVault", value);
            return entity;
        }

        public static T SetEncumbranceImmunity<T>(this T entity, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("encumbranceImmunity", value);
            return entity;
        }

        public static T SetEnhancedJump<T>(this T entity, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("enhancedJump", value);
            return entity;
        }

        public static T SetExpertClimber<T>(this T entity, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("expertClimber", value);
            return entity;
        }

        public static T SetFastClimber<T>(this T entity, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("fastClimber", value);
            return entity;
        }

        public static T SetForceMinimalBaseSpeed<T>(this T entity, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("forceMinimalBaseSpeed", value);
            return entity;
        }

        public static T SetHeavyArmorImmunity<T>(this T entity, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("heavyArmorImmunity", value);
            return entity;
        }

        public static T SetImmuneDifficultTerrain<T>(this T entity, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("immuneDifficultTerrain", value);
            return entity;
        }

        public static T SetMinimalBaseSpeed<T>(this T entity, int value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("minimalBaseSpeed", value);
            return entity;
        }

        public static T SetMinMaxMoves<T>(this T entity, int value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("minMaxMoves", value);
            return entity;
        }

        public static T SetMoveMode<T>(this T entity, MoveMode value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("moveMode", value);
            return entity;
        }

        public static T SetSpeedAddBase<T>(this T entity, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("speedAddBase", value);
            return entity;
        }
    }
}