using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class QuestTreeDefinitionExtensions
    {
        public static T SetAllQuestStepDescriptions<T>(this T definition, List<QuestStepDescription> value)
            where T : QuestTreeDefinition
        {
            definition.SetField("allQuestStepDescriptions", value);
            return definition;
        }

        public static T SetSerializeVersion<T>(this T definition, int value)
            where T : QuestTreeDefinition
        {
            definition.SetField("serializeVersion", value);
            return definition;
        }
    }
}