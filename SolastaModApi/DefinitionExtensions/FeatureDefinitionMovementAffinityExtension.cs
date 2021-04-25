using SolastaModApi.Infrastructure;
using static RuleDefinitions;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionMovementAffinityExtensions
    {
        public static FeatureDefinitionMovementAffinity SetAdditionalFallThreshold(this FeatureDefinitionMovementAffinity definition, int value)
        {
            definition.SetField("additionalFallThreshold", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetAdditionalJumpCells(this FeatureDefinitionMovementAffinity definition, int value)
        {
            definition.SetField("additionalJumpCells", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetAppliesToAllModes(this FeatureDefinitionMovementAffinity definition, bool value)
        {
            definition.SetField("appliesToAllModes", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetBaseSpeedAdditiveModifier(this FeatureDefinitionMovementAffinity definition, int value)
        {
            definition.SetField("baseSpeedAdditiveModifier", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetBaseSpeedMultiplicativeModifier(this FeatureDefinitionMovementAffinity definition, float value)
        {
            definition.SetField("baseSpeedMultiplicativeModifier", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetCanMoveOnWalls(this FeatureDefinitionMovementAffinity definition, bool value)
        {
            definition.SetField("canMoveOnWalls", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetDisableClimb(this FeatureDefinitionMovementAffinity definition, bool value)
        {
            definition.SetField("disableClimb", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetDisableDrop(this FeatureDefinitionMovementAffinity definition, bool value)
        {
            definition.SetField("disableDrop", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetDisableJump(this FeatureDefinitionMovementAffinity definition, bool value)
        {
            definition.SetField("disableJump", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetDisableVault(this FeatureDefinitionMovementAffinity definition, bool value)
        {
            definition.SetField("disableVault", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetEncumbranceImmunity(this FeatureDefinitionMovementAffinity definition, bool value)
        {
            definition.SetField("encumbranceImmunity", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetEnhancedJump(this FeatureDefinitionMovementAffinity definition, bool value)
        {
            definition.SetField("enhancedJump", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetExpertClimber(this FeatureDefinitionMovementAffinity definition, bool value)
        {
            definition.SetField("expertClimber", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetFastClimber(this FeatureDefinitionMovementAffinity definition, bool value)
        {
            definition.SetField("fastClimber", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetForceMinimalBaseSpeed(this FeatureDefinitionMovementAffinity definition, bool value)
        {
            definition.SetField("forceMinimalBaseSpeed", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetHeavyArmorImmunity(this FeatureDefinitionMovementAffinity definition, bool value)
        {
            definition.SetField("heavyArmorImmunity", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetImmuneDifficultTerrain(this FeatureDefinitionMovementAffinity definition, bool value)
        {
            definition.SetField("immuneDifficultTerrain", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetMinimalBaseSpeed(this FeatureDefinitionMovementAffinity definition, int value)
        {
            definition.SetField("minimalBaseSpeed", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetMinMaxMoves(this FeatureDefinitionMovementAffinity definition, int value)
        {
            definition.SetField("minMaxMoves", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetMoveMode(this FeatureDefinitionMovementAffinity definition, MoveMode value)
        {
            definition.SetField("moveMode", value);
            return definition;
        }

        public static FeatureDefinitionMovementAffinity SetSpeedAddBase(this FeatureDefinitionMovementAffinity definition, bool value)
        {
            definition.SetField("speedAddBase", value);
            return definition;
        }
    }
}