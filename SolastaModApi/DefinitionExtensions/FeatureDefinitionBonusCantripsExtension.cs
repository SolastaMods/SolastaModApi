using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class FeatureDefinitionBonusCantripsExtensions
    {
        public static void SetBonusCantrips(this FeatureDefinitionBonusCantrips definition, List<SpellDefinition> value)
        {
            definition.SetField("bonusCantrips", value);
        }
    }
}