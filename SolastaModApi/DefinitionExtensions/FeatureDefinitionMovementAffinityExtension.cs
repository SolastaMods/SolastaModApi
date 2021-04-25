using SolastaModApi.Infrastructure;
using System;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionMovementAffinityExtensions
    {
        public static void SetAdditionalFallThreshold(this FeatureDefinitionMovementAffinity definition, Int32 value)
        {
            definition.SetField("additionalFallThreshold", value);
        }

        public static void SetAdditionalJumpCells(this FeatureDefinitionMovementAffinity definition, Int32 value)
        {
            definition.SetField("additionalJumpCells", value);
        }

        public static void SetAppliesToAllModes(this FeatureDefinitionMovementAffinity definition, Boolean value)
        {
            definition.SetField("appliesToAllModes", value);
        }

        public static void SetBaseSpeedAdditiveModifier(this FeatureDefinitionMovementAffinity definition, Int32 value)
        {
            definition.SetField("baseSpeedAdditiveModifier", value);
        }

        public static void SetBaseSpeedMultiplicativeModifier(this FeatureDefinitionMovementAffinity definition, Single value)
        {
            definition.SetField("baseSpeedMultiplicativeModifier", value);
        }

        public static void SetCanMoveOnWalls(this FeatureDefinitionMovementAffinity definition, Boolean value)
        {
            definition.SetField("canMoveOnWalls", value);
        }

        public static void SetDisableClimb(this FeatureDefinitionMovementAffinity definition, Boolean value)
        {
            definition.SetField("disableClimb", value);
        }

        public static void SetDisableDrop(this FeatureDefinitionMovementAffinity definition, Boolean value)
        {
            definition.SetField("disableDrop", value);
        }

        public static void SetDisableJump(this FeatureDefinitionMovementAffinity definition, Boolean value)
        {
            definition.SetField("disableJump", value);
        }

        public static void SetDisableVault(this FeatureDefinitionMovementAffinity definition, Boolean value)
        {
            definition.SetField("disableVault", value);
        }

        public static void SetEncumbranceImmunity(this FeatureDefinitionMovementAffinity definition, Boolean value)
        {
            definition.SetField("encumbranceImmunity", value);
        }

        public static void SetEnhancedJump(this FeatureDefinitionMovementAffinity definition, Boolean value)
        {
            definition.SetField("enhancedJump", value);
        }

        public static void SetExpertClimber(this FeatureDefinitionMovementAffinity definition, Boolean value)
        {
            definition.SetField("expertClimber", value);
        }

        public static void SetFastClimber(this FeatureDefinitionMovementAffinity definition, Boolean value)
        {
            definition.SetField("fastClimber", value);
        }

        public static void SetForceMinimalBaseSpeed(this FeatureDefinitionMovementAffinity definition, Boolean value)
        {
            definition.SetField("forceMinimalBaseSpeed", value);
        }

        public static void SetHeavyArmorImmunity(this FeatureDefinitionMovementAffinity definition, Boolean value)
        {
            definition.SetField("heavyArmorImmunity", value);
        }

        public static void SetImmuneDifficultTerrain(this FeatureDefinitionMovementAffinity definition, Boolean value)
        {
            definition.SetField("immuneDifficultTerrain", value);
        }

        public static void SetMinimalBaseSpeed(this FeatureDefinitionMovementAffinity definition, Int32 value)
        {
            definition.SetField("minimalBaseSpeed", value);
        }

        public static void SetMinMaxMoves(this FeatureDefinitionMovementAffinity definition, Int32 value)
        {
            definition.SetField("minMaxMoves", value);
        }

        public static void SetMoveMode(this FeatureDefinitionMovementAffinity definition, MoveMode value)
        {
            definition.SetField("moveMode", value);
        }

        public static void SetSpeedAddBase(this FeatureDefinitionMovementAffinity definition, Boolean value)
        {
            definition.SetField("speedAddBase", value);
        }
    }
}