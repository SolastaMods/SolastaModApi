using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionAutoPreparedSpellsExtensions
    {
        public static T SetSpellcastingClass<T>(this T definition, CharacterClassDefinition value)
            where T : FeatureDefinitionAutoPreparedSpells
        {
            definition.SetField("spellcastingClass", value);
            return definition;
        }
    }
}