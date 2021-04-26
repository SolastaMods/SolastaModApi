using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi
{
    public static class AdventureLogDefinitionExtensions
    {
        public static T SetBattleHeight<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("battleHeight", value);
            return definition;
        }

        public static T SetCampaignStartHeaderHeight<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("campaignStartHeaderHeight", value);
            return definition;
        }

        public static T SetCampaignStartLineHeight<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("campaignStartLineHeight", value);
            return definition;
        }

        public static T SetCampaignStartTrailingHeight<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("campaignStartTrailingHeight", value);
            return definition;
        }

        public static T SetCampaignStartWordSpacing<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("campaignStartWordSpacing", value);
            return definition;
        }

        public static T SetConversationHeaderHeight<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("conversationHeaderHeight", value);
            return definition;
        }

        public static T SetConversationIndentWidth<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("conversationIndentWidth", value);
            return definition;
        }

        public static T SetConversationLineHeight<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("conversationLineHeight", value);
            return definition;
        }

        public static T SetConversationParagraphSpacing<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("conversationParagraphSpacing", value);
            return definition;
        }

        public static T SetConversationTrailingHeight<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("conversationTrailingHeight", value);
            return definition;
        }

        public static T SetConversationWordSpacing<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("conversationWordSpacing", value);
            return definition;
        }

        public static T SetNewDayHeight<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("newDayHeight", value);
            return definition;
        }

        public static T SetQuestHeaderHeight<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("questHeaderHeight", value);
            return definition;
        }

        public static T SetQuestLineHeight<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("questLineHeight", value);
            return definition;
        }

        public static T SetQuestParagraphSpacing<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("questParagraphSpacing", value);
            return definition;
        }

        public static T SetQuestTrailingHeight<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("questTrailingHeight", value);
            return definition;
        }

        public static T SetQuestWordSpacing<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("questWordSpacing", value);
            return definition;
        }

        public static T SetRelationHeight<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("relationHeight", value);
            return definition;
        }

        public static T SetSectionHeaderHeight<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("sectionHeaderHeight", value);
            return definition;
        }

        public static T SetStyleDuplets<T>(this T definition, List<AdventureStyleDuplet> value)
            where T : AdventureLogDefinition
        {
            definition.SetField("styleDuplets", value);
            return definition;
        }

        public static T SetTravelFooterHeight<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("travelFooterHeight", value);
            return definition;
        }

        public static T SetTravelHeaderHeightDestination<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("travelHeaderHeightDestination", value);
            return definition;
        }

        public static T SetTravelHeaderHeightNoDestination<T>(this T definition, float value)
            where T : AdventureLogDefinition
        {
            definition.SetField("travelHeaderHeightNoDestination", value);
            return definition;
        }
    }
}