using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class ToolTypeDefinitionExtensions
    {
        public static T SetCraftingAbilityScore<T>(this T definition, string value)
            where T : ToolTypeDefinition
        {
            definition.SetField("craftingAbilityScore", value);
            return definition;
        }

        public static T SetHasParentCategory<T>(this T definition, bool value)
            where T : ToolTypeDefinition
        {
            definition.SetField("hasParentCategory", value);
            return definition;
        }

        public static T SetToolCategory<T>(this T definition, string value)
            where T : ToolTypeDefinition
        {
            definition.SetField("toolCategory", value);
            return definition;
        }
    }
}