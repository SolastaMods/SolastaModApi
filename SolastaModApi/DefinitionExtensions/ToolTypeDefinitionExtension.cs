using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class ToolTypeDefinitionExtensions
    {
        public static void SetCraftingAbilityScore(this ToolTypeDefinition definition, String value)
        {
            definition.SetField("craftingAbilityScore", value);
        }

        public static void SetHasParentCategory(this ToolTypeDefinition definition, Boolean value)
        {
            definition.SetField("hasParentCategory", value);
        }

        public static void SetRequiredProficiencyOptions(this ToolTypeDefinition definition, List<String> value)
        {
            definition.SetField("requiredProficiencyOptions", value);
        }

        public static void SetToolCategory(this ToolTypeDefinition definition, String value)
        {
            definition.SetField("toolCategory", value);
        }
    }
}