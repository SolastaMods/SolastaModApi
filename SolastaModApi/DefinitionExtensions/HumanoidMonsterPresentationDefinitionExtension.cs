using SolastaModApi.Infrastructure;
using UnityEngine;
using System;
using System.Collections.Generic;
using static RuleDefinitions;
using static MorphotypeElementDefinition;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class HumanoidMonsterPresentationDefinitionExtensions
    {
        public static void SetAgeMorphotypeValue(this HumanoidMonsterPresentationDefinition definition, Single value)
        {
            definition.SetField("ageMorphotypeValue", value);
        }

        public static void SetArmorDefinition(this HumanoidMonsterPresentationDefinition definition, String value)
        {
            definition.SetField("armorDefinition", value);
        }

        public static void SetBeardShapeMorphotype(this HumanoidMonsterPresentationDefinition definition, String value)
        {
            definition.SetField("beardShapeMorphotype", value);
        }

        public static void SetBodyDecorationMorphotype(this HumanoidMonsterPresentationDefinition definition, String value)
        {
            definition.SetField("bodyDecorationMorphotype", value);
        }

        public static void SetEyeColorMorphotype(this HumanoidMonsterPresentationDefinition definition, String value)
        {
            definition.SetField("eyeColorMorphotype", value);
        }

        public static void SetFaceShapeMorphotype(this HumanoidMonsterPresentationDefinition definition, String value)
        {
            definition.SetField("faceShapeMorphotype", value);
        }

        public static void SetFirstColor(this HumanoidMonsterPresentationDefinition definition, Color value)
        {
            definition.SetField("firstColor", value);
        }

        public static void SetFourthColor(this HumanoidMonsterPresentationDefinition definition, Color value)
        {
            definition.SetField("fourthColor", value);
        }

        public static void SetHairColorMorphotype(this HumanoidMonsterPresentationDefinition definition, String value)
        {
            definition.SetField("hairColorMorphotype", value);
        }

        public static void SetHairShapeMorphotype(this HumanoidMonsterPresentationDefinition definition, String value)
        {
            definition.SetField("hairShapeMorphotype", value);
        }

        public static void SetHasMonsterPortraitBackground(this HumanoidMonsterPresentationDefinition definition, Boolean value)
        {
            definition.SetField("hasMonsterPortraitBackground", value);
        }

        public static void SetHelmetDefinition(this HumanoidMonsterPresentationDefinition definition, String value)
        {
            definition.SetField("helmetDefinition", value);
        }

        public static void SetItemDefinitionMainHand(this HumanoidMonsterPresentationDefinition definition, ItemDefinition value)
        {
            definition.SetField("itemDefinitionMainHand", value);
        }

        public static void SetItemDefinitionOffHand(this HumanoidMonsterPresentationDefinition definition, ItemDefinition value)
        {
            definition.SetField("itemDefinitionOffHand", value);
        }

        public static void SetMorphotypeElements(this HumanoidMonsterPresentationDefinition definition, Dictionary<ElementCategory, String> value)
        {
            definition.SetField("morphotypeElements", value);
        }

        public static void SetMorphotypeElementsAdditionalValues(this HumanoidMonsterPresentationDefinition definition, Dictionary<ElementCategory, Single> value)
        {
            definition.SetField("morphotypeElementsAdditionalValues", value);
        }

        public static void SetMusculatureMorphotypeValue(this HumanoidMonsterPresentationDefinition definition, Single value)
        {
            definition.SetField("musculatureMorphotypeValue", value);
        }

        public static void SetOriginMorphotype(this HumanoidMonsterPresentationDefinition definition, String value)
        {
            definition.SetField("originMorphotype", value);
        }

        public static void SetOverrideWieldedItems(this HumanoidMonsterPresentationDefinition definition, Boolean value)
        {
            definition.SetField("overrideWieldedItems", value);
        }

        public static void SetRaceDefinition(this HumanoidMonsterPresentationDefinition definition, CharacterRaceDefinition value)
        {
            definition.SetField("raceDefinition", value);
        }

        public static void SetSecondColor(this HumanoidMonsterPresentationDefinition definition, Color value)
        {
            definition.SetField("secondColor", value);
        }

        public static void SetSex(this HumanoidMonsterPresentationDefinition definition, CreatureSex value)
        {
            definition.SetField("sex", value);
        }

        public static void SetShowHelmet(this HumanoidMonsterPresentationDefinition definition, Boolean value)
        {
            definition.SetField("showHelmet", value);
        }

        public static void SetSkinMorphotype(this HumanoidMonsterPresentationDefinition definition, String value)
        {
            definition.SetField("skinMorphotype", value);
        }

        public static void SetSubRaceDefinition(this HumanoidMonsterPresentationDefinition definition, CharacterRaceDefinition value)
        {
            definition.SetField("subRaceDefinition", value);
        }

        public static void SetTabardDefinition(this HumanoidMonsterPresentationDefinition definition, String value)
        {
            definition.SetField("tabardDefinition", value);
        }

        public static void SetThirdColor(this HumanoidMonsterPresentationDefinition definition, Color value)
        {
            definition.SetField("thirdColor", value);
        }
    }
}