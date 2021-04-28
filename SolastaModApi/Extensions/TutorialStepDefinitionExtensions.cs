using SolastaModApi.Infrastructure;

namespace SolastaModApi
{
    public static class TutorialStepDefinitionExtensions
    {
        public static T SetHideCharacterInspection<T>(this T entity, bool value)
            where T : TutorialStepDefinition
        {
            entity.SetField("hideCharacterInspection", value);
            return entity;
        }

        public static T SetHideJournal<T>(this T entity, bool value)
            where T : TutorialStepDefinition
        {
            entity.SetField("hideJournal", value);
            return entity;
        }

        public static T SetNextStepDefinition<T>(this T entity, TutorialStepDefinition value)
            where T : TutorialStepDefinition
        {
            entity.SetField("nextStepDefinition", value);
            return entity;
        }
    }
}