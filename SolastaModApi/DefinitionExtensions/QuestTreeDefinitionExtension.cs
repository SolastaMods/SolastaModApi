using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class QuestTreeDefinitionExtensions
    {
        public static QuestTreeDefinition SetAllQuestStepDescriptions(this QuestTreeDefinition definition, List<QuestStepDescription> value)
        {
            definition.SetField("allQuestStepDescriptions", value);
            return definition;
        }

        public static QuestTreeDefinition SetSerializeVersion(this QuestTreeDefinition definition, int value)
        {
            definition.SetField("serializeVersion", value);
            return definition;
        }
    }
}