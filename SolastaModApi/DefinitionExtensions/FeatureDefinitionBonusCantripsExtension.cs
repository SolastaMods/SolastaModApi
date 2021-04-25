using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionBonusCantripsExtensions
    {
        public static FeatureDefinitionBonusCantrips SetBonusCantrips(this FeatureDefinitionBonusCantrips definition, List<SpellDefinition> value)
        {
            definition.SetField("bonusCantrips", value);
            return definition;
        }
    }
}