using SolastaModApi.Infrastructure;
using static RuleDefinitions;
using static GameCampaignDefinitions;

namespace SolastaModApi
{
    public static class DocumentDescriptionExtensions
    {
        public static T SetDestroyAfterReading<T>(this T entity, bool value)
            where T : DocumentDescription
        {
            entity.SetField("destroyAfterReading", value);
            return entity;
        }

        public static T SetFormat<T>(this T entity, DocumentDescription.FormatType value)
            where T : DocumentDescription
        {
            entity.SetField("format", value);
            return entity;
        }

        public static T SetLanguage<T>(this T entity, string value)
            where T : DocumentDescription
        {
            entity.SetField("language", value);
            return entity;
        }

        public static T SetLocationDefinition<T>(this T entity, LocationDefinition value)
            where T : DocumentDescription
        {
            entity.SetField("locationDefinition", value);
            return entity;
        }

        public static T SetLocationKnowledgeLevel<T>(this T entity, NodeKnowledge value)
            where T : DocumentDescription
        {
            entity.SetField("locationKnowledgeLevel", value);
            return entity;
        }

        public static T SetLoreType<T>(this T entity, LoreType value)
            where T : DocumentDescription
        {
            entity.SetField("loreType", value);
            return entity;
        }

        public static T SetRecipeDefinition<T>(this T entity, RecipeDefinition value)
            where T : DocumentDescription
        {
            entity.SetField("recipeDefinition", value);
            return entity;
        }

        public static T SetScript<T>(this T entity, DocumentDescription.ScriptType value)
            where T : DocumentDescription
        {
            entity.SetField("script", value);
            return entity;
        }
    }
}