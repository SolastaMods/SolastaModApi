using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class FormationDefinitionExtensions
    {
        public static T SetDefaultFormation<T>(this T entity, bool value)
            where T : FormationDefinition
        {
            entity.SetField("defaultFormation", value);
            return entity;
        }
    }
}