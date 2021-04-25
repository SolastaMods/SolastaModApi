using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class RecipeDefinitionExtensions
    {
        public static RecipeDefinition SetCraftedItem(this RecipeDefinition definition, ItemDefinition value)
        {
            definition.SetField("craftedItem", value);
            return definition;
        }

        public static RecipeDefinition SetCraftingDC(this RecipeDefinition definition, int value)
        {
            definition.SetField("craftingDC", value);
            return definition;
        }

        public static RecipeDefinition SetCraftingHours(this RecipeDefinition definition, int value)
        {
            definition.SetField("craftingHours", value);
            return definition;
        }

        public static RecipeDefinition SetIngredients(this RecipeDefinition definition, List<IngredientOccurenceDescription> value)
        {
            definition.SetField("ingredients", value);
            return definition;
        }

        public static RecipeDefinition SetSpellDefinition(this RecipeDefinition definition, SpellDefinition value)
        {
            definition.SetField("spellDefinition", value);
            return definition;
        }

        public static RecipeDefinition SetStackCount(this RecipeDefinition definition, int value)
        {
            definition.SetField("stackCount", value);
            return definition;
        }

        public static RecipeDefinition SetToolTypeDefinition(this RecipeDefinition definition, ToolTypeDefinition value)
        {
            definition.SetField("toolTypeDefinition", value);
            return definition;
        }
    }
}