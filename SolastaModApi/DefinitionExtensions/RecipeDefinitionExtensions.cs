using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class RecipeDefinitionExtensions
    {
        public static T SetCraftedItem<T>(this T definition, ItemDefinition value)
            where T : RecipeDefinition
        {
            definition.SetField("craftedItem", value);
            return definition;
        }

        public static T SetCraftingDC<T>(this T definition, int value)
            where T : RecipeDefinition
        {
            definition.SetField("craftingDC", value);
            return definition;
        }

        public static T SetCraftingHours<T>(this T definition, int value)
            where T : RecipeDefinition
        {
            definition.SetField("craftingHours", value);
            return definition;
        }

        public static T SetIngredients<T>(this T definition, List<IngredientOccurenceDescription> value)
            where T : RecipeDefinition
        {
            definition.SetField("ingredients", value);
            return definition;
        }

        public static T SetSpellDefinition<T>(this T definition, SpellDefinition value)
            where T : RecipeDefinition
        {
            definition.SetField("spellDefinition", value);
            return definition;
        }

        public static T SetStackCount<T>(this T definition, int value)
            where T : RecipeDefinition
        {
            definition.SetField("stackCount", value);
            return definition;
        }

        public static T SetToolTypeDefinition<T>(this T definition, ToolTypeDefinition value)
            where T : RecipeDefinition
        {
            definition.SetField("toolTypeDefinition", value);
            return definition;
        }
    }
}