using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class FeatureDefinitionBonusCantripsExtensions
    {
        public static T SetBonusCantrips<T>(this T definition, List<SpellDefinition> value)
            where T : FeatureDefinitionBonusCantrips
        {
            definition.SetField("bonusCantrips", value);
            return definition;
        }
    }
}