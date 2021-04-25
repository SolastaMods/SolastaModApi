using SolastaModApi.Infrastructure;
using System;
using System.Collections.Generic;
using static BanterDefinitions;
using static CharacterClassDefinition;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class CharacterBackgroundDefinitionExtensions
    {
        public static void SetBackgroudSubtypes(this CharacterBackgroundDefinition definition, List<String> value)
        {
            definition.SetField("backgroudSubtypes", value);
        }

        public static void SetBanterList(this CharacterBackgroundDefinition definition, BanterList value)
        {
            definition.SetField("banterList", value);
        }

        public static void SetDefaultOptionalPersonalityFlags(this CharacterBackgroundDefinition definition, List<String> value)
        {
            definition.SetField("defaultOptionalPersonalityFlags", value);
        }

        public static void SetEquipmentRows(this CharacterBackgroundDefinition definition, List<HeroEquipmentRow> value)
        {
            definition.SetField("equipmentRows", value);
        }

        public static void SetFeatures(this CharacterBackgroundDefinition definition, List<FeatureDefinition> value)
        {
            definition.SetField("features", value);
        }

        public static void SetForbiddenAlignments(this CharacterBackgroundDefinition definition, List<String> value)
        {
            definition.SetField("forbiddenAlignments", value);
        }

        public static void SetHasSubtype(this CharacterBackgroundDefinition definition, Boolean value)
        {
            definition.SetField("hasSubtype", value);
        }

        public static void SetOptionalPersonalityFlags(this CharacterBackgroundDefinition definition, List<PersonalityFlagOccurence> value)
        {
            definition.SetField("optionalPersonalityFlags", value);
        }

        public static void SetRequiresDeity(this CharacterBackgroundDefinition definition, Boolean value)
        {
            definition.SetField("requiresDeity", value);
        }

        public static void SetStaticPersonalityFlags(this CharacterBackgroundDefinition definition, List<PersonalityFlagOccurence> value)
        {
            definition.SetField("staticPersonalityFlags", value);
        }

        public static void SetSubTypeName(this CharacterBackgroundDefinition definition, String value)
        {
            definition.SetField("subTypeName", value);
        }
    }
}