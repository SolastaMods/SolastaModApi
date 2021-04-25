using SolastaModApi.Infrastructure;
using System.Collections.Generic;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class AdventureLogDefinitionExtensions
    {
        public static AdventureLogDefinition SetBattleHeight(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("battleHeight", value);
            return definition;
        }

        public static AdventureLogDefinition SetCampaignStartHeaderHeight(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("campaignStartHeaderHeight", value);
            return definition;
        }

        public static AdventureLogDefinition SetCampaignStartLineHeight(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("campaignStartLineHeight", value);
            return definition;
        }

        public static AdventureLogDefinition SetCampaignStartTrailingHeight(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("campaignStartTrailingHeight", value);
            return definition;
        }

        public static AdventureLogDefinition SetCampaignStartWordSpacing(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("campaignStartWordSpacing", value);
            return definition;
        }

        public static AdventureLogDefinition SetConversationHeaderHeight(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("conversationHeaderHeight", value);
            return definition;
        }

        public static AdventureLogDefinition SetConversationIndentWidth(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("conversationIndentWidth", value);
            return definition;
        }

        public static AdventureLogDefinition SetConversationLineHeight(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("conversationLineHeight", value);
            return definition;
        }

        public static AdventureLogDefinition SetConversationParagraphSpacing(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("conversationParagraphSpacing", value);
            return definition;
        }

        public static AdventureLogDefinition SetConversationTrailingHeight(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("conversationTrailingHeight", value);
            return definition;
        }

        public static AdventureLogDefinition SetConversationWordSpacing(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("conversationWordSpacing", value);
            return definition;
        }

        public static AdventureLogDefinition SetNewDayHeight(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("newDayHeight", value);
            return definition;
        }

        public static AdventureLogDefinition SetQuestHeaderHeight(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("questHeaderHeight", value);
            return definition;
        }

        public static AdventureLogDefinition SetQuestLineHeight(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("questLineHeight", value);
            return definition;
        }

        public static AdventureLogDefinition SetQuestParagraphSpacing(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("questParagraphSpacing", value);
            return definition;
        }

        public static AdventureLogDefinition SetQuestTrailingHeight(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("questTrailingHeight", value);
            return definition;
        }

        public static AdventureLogDefinition SetQuestWordSpacing(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("questWordSpacing", value);
            return definition;
        }

        public static AdventureLogDefinition SetRelationHeight(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("relationHeight", value);
            return definition;
        }

        public static AdventureLogDefinition SetSectionHeaderHeight(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("sectionHeaderHeight", value);
            return definition;
        }

        public static AdventureLogDefinition SetStyleDuplets(this AdventureLogDefinition definition, List<AdventureStyleDuplet> value)
        {
            definition.SetField("styleDuplets", value);
            return definition;
        }

        public static AdventureLogDefinition SetTravelFooterHeight(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("travelFooterHeight", value);
            return definition;
        }

        public static AdventureLogDefinition SetTravelHeaderHeightDestination(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("travelHeaderHeightDestination", value);
            return definition;
        }

        public static AdventureLogDefinition SetTravelHeaderHeightNoDestination(this AdventureLogDefinition definition, float value)
        {
            definition.SetField("travelHeaderHeightNoDestination", value);
            return definition;
        }
    }
}