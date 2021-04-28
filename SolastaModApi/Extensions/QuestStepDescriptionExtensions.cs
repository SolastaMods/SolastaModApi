using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class QuestStepDescriptionExtensions
    {
        public static T SetGuiPresentation<T>(this T entity, GuiPresentation value)
            where T : QuestStepDescription
        {
            entity.SetField("guiPresentation", value);
            return entity;
        }
    }
}