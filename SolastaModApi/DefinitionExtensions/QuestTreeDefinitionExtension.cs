using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class QuestTreeDefinitionExtensions
    {
        public static void SetAllQuestStepDescriptions(this QuestTreeDefinition definition, List<QuestStepDescription> value)
        {
            definition.SetField("allQuestStepDescriptions", value);
        }

        public static void SetSerializeVersion(this QuestTreeDefinition definition, Int32 value)
        {
            definition.SetField("serializeVersion", value);
        }
    }
}