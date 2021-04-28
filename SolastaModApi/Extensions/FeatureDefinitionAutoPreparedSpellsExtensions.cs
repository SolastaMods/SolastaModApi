using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FeatureDefinitionAutoPreparedSpellsExtensions
    {
        public static T SetSpellcastingClass<T>(this T entity, CharacterClassDefinition value)
            where T : FeatureDefinitionAutoPreparedSpells
        {
            entity.SetField("spellcastingClass", value);
            return entity;
        }
    }
}