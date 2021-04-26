using SolastaModApi.Infrastructure;
using System.Collections.Generic;
using static BanterDefinitions;
using static CharacterClassDefinition;

namespace SolastaModApi
{
    public static class CharacterBackgroundDefinitionExtensions
    {
        public static T SetBackgroudSubtypes<T>(this T definition, List<string> value)
            where T : CharacterBackgroundDefinition
        {
            definition.SetField("backgroudSubtypes", value);
            return definition;
        }

        public static T SetBanterList<T>(this T definition, BanterList value)
            where T : CharacterBackgroundDefinition
        {
            definition.SetField("banterList", value);
            return definition;
        }

        public static T SetDefaultOptionalPersonalityFlags<T>(this T definition, List<string> value)
            where T : CharacterBackgroundDefinition
        {
            definition.SetField("defaultOptionalPersonalityFlags", value);
            return definition;
        }

        public static T SetEquipmentRows<T>(this T definition, List<HeroEquipmentRow> value)
            where T : CharacterBackgroundDefinition
        {
            definition.SetField("equipmentRows", value);
            return definition;
        }

        public static T SetFeatures<T>(this T definition, List<FeatureDefinition> value)
            where T : CharacterBackgroundDefinition
        {
            definition.SetField("features", value);
            return definition;
        }

        public static T SetForbiddenAlignments<T>(this T definition, List<string> value)
            where T : CharacterBackgroundDefinition
        {
            definition.SetField("forbiddenAlignments", value);
            return definition;
        }

        public static T SetHasSubtype<T>(this T definition, bool value)
            where T : CharacterBackgroundDefinition
        {
            definition.SetField("hasSubtype", value);
            return definition;
        }

        public static T SetOptionalPersonalityFlags<T>(this T definition, List<PersonalityFlagOccurence> value)
            where T : CharacterBackgroundDefinition
        {
            definition.SetField("optionalPersonalityFlags", value);
            return definition;
        }

        public static T SetRequiresDeity<T>(this T definition, bool value)
            where T : CharacterBackgroundDefinition
        {
            definition.SetField("requiresDeity", value);
            return definition;
        }

        public static T SetStaticPersonalityFlags<T>(this T definition, List<PersonalityFlagOccurence> value)
            where T : CharacterBackgroundDefinition
        {
            definition.SetField("staticPersonalityFlags", value);
            return definition;
        }

        public static T SetSubTypeName<T>(this T definition, string value)
            where T : CharacterBackgroundDefinition
        {
            definition.SetField("subTypeName", value);
            return definition;
        }
    }
}