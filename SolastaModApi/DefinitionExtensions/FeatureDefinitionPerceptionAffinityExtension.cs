using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionPerceptionAffinityExtensions
    {
        public static FeatureDefinitionPerceptionAffinity SetCannotBeSurprised(this FeatureDefinitionPerceptionAffinity definition, bool value)
        {
            definition.SetField("cannotBeSurprised", value);
            return definition;
        }

        public static FeatureDefinitionPerceptionAffinity SetCharacterFamilyRevealed(this FeatureDefinitionPerceptionAffinity definition, bool value)
        {
            definition.SetField("characterFamilyRevealed", value);
            return definition;
        }

        public static FeatureDefinitionPerceptionAffinity SetCharacterPositionRevealed(this FeatureDefinitionPerceptionAffinity definition, bool value)
        {
            definition.SetField("characterPositionRevealed", value);
            return definition;
        }

        public static FeatureDefinitionPerceptionAffinity SetImpairedSight(this FeatureDefinitionPerceptionAffinity definition, bool value)
        {
            definition.SetField("impairedSight", value);
            return definition;
        }

        public static FeatureDefinitionPerceptionAffinity SetRequiredSensesToPerceive(this FeatureDefinitionPerceptionAffinity definition, List<SenseMode.Type> value)
        {
            definition.SetField("requiredSensesToPerceive", value);
            return definition;
        }
    }
}