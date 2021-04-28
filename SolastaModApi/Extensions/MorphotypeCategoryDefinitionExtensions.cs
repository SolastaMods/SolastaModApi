using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class MorphotypeCategoryDefinitionExtensions
    {
        public static T SetChoiceForm<T>(this T entity, MorphotypeCategoryDefinition.Form value)
            where T : MorphotypeCategoryDefinition
        {
            entity.SetField("choiceForm", value);
            return entity;
        }
    }
}