using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static BanterDefinitions;
using static CharacterClassDefinition;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CharacterBackgroundDefinitionExtensions
    {
        public static CharacterBackgroundDefinition SetBackgroudSubtypes(this CharacterBackgroundDefinition definition, List<string> value)
        {
            definition.SetField("backgroudSubtypes", value);
            return definition;
        }

        public static CharacterBackgroundDefinition SetBanterList(this CharacterBackgroundDefinition definition, BanterList value)
        {
            definition.SetField("banterList", value);
            return definition;
        }

        public static CharacterBackgroundDefinition SetDefaultOptionalPersonalityFlags(this CharacterBackgroundDefinition definition, List<string> value)
        {
            definition.SetField("defaultOptionalPersonalityFlags", value);
            return definition;
        }

        public static CharacterBackgroundDefinition SetEquipmentRows(this CharacterBackgroundDefinition definition, List<HeroEquipmentRow> value)
        {
            definition.SetField("equipmentRows", value);
            return definition;
        }

        public static CharacterBackgroundDefinition SetFeatures(this CharacterBackgroundDefinition definition, List<FeatureDefinition> value)
        {
            definition.SetField("features", value);
            return definition;
        }

        public static CharacterBackgroundDefinition SetForbiddenAlignments(this CharacterBackgroundDefinition definition, List<string> value)
        {
            definition.SetField("forbiddenAlignments", value);
            return definition;
        }

        public static CharacterBackgroundDefinition SetHasSubtype(this CharacterBackgroundDefinition definition, bool value)
        {
            definition.SetField("hasSubtype", value);
            return definition;
        }

        public static CharacterBackgroundDefinition SetOptionalPersonalityFlags(this CharacterBackgroundDefinition definition, List<PersonalityFlagOccurence> value)
        {
            definition.SetField("optionalPersonalityFlags", value);
            return definition;
        }

        public static CharacterBackgroundDefinition SetRequiresDeity(this CharacterBackgroundDefinition definition, bool value)
        {
            definition.SetField("requiresDeity", value);
            return definition;
        }

        public static CharacterBackgroundDefinition SetStaticPersonalityFlags(this CharacterBackgroundDefinition definition, List<PersonalityFlagOccurence> value)
        {
            definition.SetField("staticPersonalityFlags", value);
            return definition;
        }

        public static CharacterBackgroundDefinition SetSubTypeName(this CharacterBackgroundDefinition definition, string value)
        {
            definition.SetField("subTypeName", value);
            return definition;
        }
    }
}