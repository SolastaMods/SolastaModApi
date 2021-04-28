using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class ToolTypeDefinitionExtensions
    {
        public static T SetCraftingAbilityScore<T>(this T entity, string value)
            where T : ToolTypeDefinition
        {
            entity.SetField("craftingAbilityScore", value);
            return entity;
        }

        public static T SetHasParentCategory<T>(this T entity, bool value)
            where T : ToolTypeDefinition
        {
            entity.SetField("hasParentCategory", value);
            return entity;
        }

        public static T SetToolCategory<T>(this T entity, string value)
            where T : ToolTypeDefinition
        {
            entity.SetField("toolCategory", value);
            return entity;
        }
    }
}