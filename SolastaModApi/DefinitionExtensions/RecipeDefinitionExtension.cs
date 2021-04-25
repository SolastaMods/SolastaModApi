using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class RecipeDefinitionExtensions
    {
        public static void SetCraftedItem(this RecipeDefinition definition, ItemDefinition value)
        {
            definition.SetField("craftedItem", value);
        }

        public static void SetCraftingDC(this RecipeDefinition definition, Int32 value)
        {
            definition.SetField("craftingDC", value);
        }

        public static void SetCraftingHours(this RecipeDefinition definition, Int32 value)
        {
            definition.SetField("craftingHours", value);
        }

        public static void SetIngredients(this RecipeDefinition definition, List<IngredientOccurenceDescription> value)
        {
            definition.SetField("ingredients", value);
        }

        public static void SetSpellDefinition(this RecipeDefinition definition, SpellDefinition value)
        {
            definition.SetField("spellDefinition", value);
        }

        public static void SetStackCount(this RecipeDefinition definition, Int32 value)
        {
            definition.SetField("stackCount", value);
        }

        public static void SetToolTypeDefinition(this RecipeDefinition definition, ToolTypeDefinition value)
        {
            definition.SetField("toolTypeDefinition", value);
        }
    }
}