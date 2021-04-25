using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class AdventureLogDefinitionExtensions
    {
        public static void SetBattleHeight(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("battleHeight", value);
        }

        public static void SetCampaignStartHeaderHeight(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("campaignStartHeaderHeight", value);
        }

        public static void SetCampaignStartLineHeight(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("campaignStartLineHeight", value);
        }

        public static void SetCampaignStartTrailingHeight(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("campaignStartTrailingHeight", value);
        }

        public static void SetCampaignStartWordSpacing(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("campaignStartWordSpacing", value);
        }

        public static void SetConversationHeaderHeight(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("conversationHeaderHeight", value);
        }

        public static void SetConversationIndentWidth(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("conversationIndentWidth", value);
        }

        public static void SetConversationLineHeight(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("conversationLineHeight", value);
        }

        public static void SetConversationParagraphSpacing(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("conversationParagraphSpacing", value);
        }

        public static void SetConversationTrailingHeight(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("conversationTrailingHeight", value);
        }

        public static void SetConversationWordSpacing(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("conversationWordSpacing", value);
        }

        public static void SetNewDayHeight(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("newDayHeight", value);
        }

        public static void SetQuestHeaderHeight(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("questHeaderHeight", value);
        }

        public static void SetQuestLineHeight(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("questLineHeight", value);
        }

        public static void SetQuestParagraphSpacing(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("questParagraphSpacing", value);
        }

        public static void SetQuestTrailingHeight(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("questTrailingHeight", value);
        }

        public static void SetQuestWordSpacing(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("questWordSpacing", value);
        }

        public static void SetRelationHeight(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("relationHeight", value);
        }

        public static void SetSectionHeaderHeight(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("sectionHeaderHeight", value);
        }

        public static void SetStyleDuplets(this AdventureLogDefinition definition, List<AdventureStyleDuplet> value)
        {
            definition.SetField("styleDuplets", value);
        }

        public static void SetTravelFooterHeight(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("travelFooterHeight", value);
        }

        public static void SetTravelHeaderHeightDestination(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("travelHeaderHeightDestination", value);
        }

        public static void SetTravelHeaderHeightNoDestination(this AdventureLogDefinition definition, Single value)
        {
            definition.SetField("travelHeaderHeightNoDestination", value);
        }
    }
}