using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ToolTypeDefinitionExtensions
    {
        public static ToolTypeDefinition SetCraftingAbilityScore(this ToolTypeDefinition definition, string value)
        {
            definition.SetField("craftingAbilityScore", value);
            return definition;
        }

        public static ToolTypeDefinition SetHasParentCategory(this ToolTypeDefinition definition, bool value)
        {
            definition.SetField("hasParentCategory", value);
            return definition;
        }

        public static ToolTypeDefinition SetRequiredProficiencyOptions(this ToolTypeDefinition definition, List<string> value)
        {
            definition.SetField("requiredProficiencyOptions", value);
            return definition;
        }

        public static ToolTypeDefinition SetToolCategory(this ToolTypeDefinition definition, string value)
        {
            definition.SetField("toolCategory", value);
            return definition;
        }
    }
}