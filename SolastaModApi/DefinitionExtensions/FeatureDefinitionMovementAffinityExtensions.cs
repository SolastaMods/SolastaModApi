using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class FeatureDefinitionMovementAffinityExtensions
    {
        public static T SetAdditionalFallThreshold<T>(this T definition, int value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("additionalFallThreshold", value);
            return definition;
        }

        public static T SetAdditionalJumpCells<T>(this T definition, int value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("additionalJumpCells", value);
            return definition;
        }

        public static T SetAppliesToAllModes<T>(this T definition, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("appliesToAllModes", value);
            return definition;
        }

        public static T SetBaseSpeedAdditiveModifier<T>(this T definition, int value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("baseSpeedAdditiveModifier", value);
            return definition;
        }

        public static T SetBaseSpeedMultiplicativeModifier<T>(this T definition, float value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("baseSpeedMultiplicativeModifier", value);
            return definition;
        }

        public static T SetCanMoveOnWalls<T>(this T definition, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("canMoveOnWalls", value);
            return definition;
        }

        public static T SetDisableClimb<T>(this T definition, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("disableClimb", value);
            return definition;
        }

        public static T SetDisableDrop<T>(this T definition, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("disableDrop", value);
            return definition;
        }

        public static T SetDisableJump<T>(this T definition, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("disableJump", value);
            return definition;
        }

        public static T SetDisableVault<T>(this T definition, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("disableVault", value);
            return definition;
        }

        public static T SetEncumbranceImmunity<T>(this T definition, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("encumbranceImmunity", value);
            return definition;
        }

        public static T SetEnhancedJump<T>(this T definition, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("enhancedJump", value);
            return definition;
        }

        public static T SetExpertClimber<T>(this T definition, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("expertClimber", value);
            return definition;
        }

        public static T SetFastClimber<T>(this T definition, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("fastClimber", value);
            return definition;
        }

        public static T SetForceMinimalBaseSpeed<T>(this T definition, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("forceMinimalBaseSpeed", value);
            return definition;
        }

        public static T SetHeavyArmorImmunity<T>(this T definition, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("heavyArmorImmunity", value);
            return definition;
        }

        public static T SetImmuneDifficultTerrain<T>(this T definition, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("immuneDifficultTerrain", value);
            return definition;
        }

        public static T SetMinimalBaseSpeed<T>(this T definition, int value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("minimalBaseSpeed", value);
            return definition;
        }

        public static T SetMinMaxMoves<T>(this T definition, int value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("minMaxMoves", value);
            return definition;
        }

        public static T SetMoveMode<T>(this T definition, MoveMode value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("moveMode", value);
            return definition;
        }

        public static T SetSpeedAddBase<T>(this T definition, bool value)
            where T : FeatureDefinitionMovementAffinity
        {
            definition.SetField("speedAddBase", value);
            return definition;
        }
    }
}