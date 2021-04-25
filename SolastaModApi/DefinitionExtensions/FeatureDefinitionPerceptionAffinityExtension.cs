using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionPerceptionAffinityExtensions
    {
        public static void SetCannotBeSurprised(this FeatureDefinitionPerceptionAffinity definition, Boolean value)
        {
            definition.SetField("cannotBeSurprised", value);
        }

        public static void SetCharacterFamilyRevealed(this FeatureDefinitionPerceptionAffinity definition, Boolean value)
        {
            definition.SetField("characterFamilyRevealed", value);
        }

        public static void SetCharacterPositionRevealed(this FeatureDefinitionPerceptionAffinity definition, Boolean value)
        {
            definition.SetField("characterPositionRevealed", value);
        }

        public static void SetImpairedSight(this FeatureDefinitionPerceptionAffinity definition, Boolean value)
        {
            definition.SetField("impairedSight", value);
        }

        public static void SetRequiredSensesToPerceive(this FeatureDefinitionPerceptionAffinity definition, List<SenseMode.Type> value)
        {
            definition.SetField("requiredSensesToPerceive", value);
        }
    }
}