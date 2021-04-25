using SolastaModApi.Infrastructure;
using UnityEngine;
using System.Collections.Generic;
using static RuleDefinitions;
using static MorphotypeElementDefinition;

namespace SolastaModApi.BuilderHelpers.DefinitionExtensions
{
    public static class HumanoidMonsterPresentationDefinitionExtensions
    {
        public static HumanoidMonsterPresentationDefinition SetAgeMorphotypeValue(this HumanoidMonsterPresentationDefinition definition, float value)
        {
            definition.SetField("ageMorphotypeValue", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetArmorDefinition(this HumanoidMonsterPresentationDefinition definition, string value)
        {
            definition.SetField("armorDefinition", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetBeardShapeMorphotype(this HumanoidMonsterPresentationDefinition definition, string value)
        {
            definition.SetField("beardShapeMorphotype", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetBodyDecorationMorphotype(this HumanoidMonsterPresentationDefinition definition, string value)
        {
            definition.SetField("bodyDecorationMorphotype", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetEyeColorMorphotype(this HumanoidMonsterPresentationDefinition definition, string value)
        {
            definition.SetField("eyeColorMorphotype", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetFaceShapeMorphotype(this HumanoidMonsterPresentationDefinition definition, string value)
        {
            definition.SetField("faceShapeMorphotype", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetFirstColor(this HumanoidMonsterPresentationDefinition definition, Color value)
        {
            definition.SetField("firstColor", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetFourthColor(this HumanoidMonsterPresentationDefinition definition, Color value)
        {
            definition.SetField("fourthColor", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetHairColorMorphotype(this HumanoidMonsterPresentationDefinition definition, string value)
        {
            definition.SetField("hairColorMorphotype", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetHairShapeMorphotype(this HumanoidMonsterPresentationDefinition definition, string value)
        {
            definition.SetField("hairShapeMorphotype", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetHasMonsterPortraitBackground(this HumanoidMonsterPresentationDefinition definition, bool value)
        {
            definition.SetField("hasMonsterPortraitBackground", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetHelmetDefinition(this HumanoidMonsterPresentationDefinition definition, string value)
        {
            definition.SetField("helmetDefinition", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetItemDefinitionMainHand(this HumanoidMonsterPresentationDefinition definition, ItemDefinition value)
        {
            definition.SetField("itemDefinitionMainHand", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetItemDefinitionOffHand(this HumanoidMonsterPresentationDefinition definition, ItemDefinition value)
        {
            definition.SetField("itemDefinitionOffHand", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetMorphotypeElements(this HumanoidMonsterPresentationDefinition definition, Dictionary<ElementCategory, string> value)
        {
            definition.SetField("morphotypeElements", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetMorphotypeElementsAdditionalValues(this HumanoidMonsterPresentationDefinition definition, Dictionary<ElementCategory, float> value)
        {
            definition.SetField("morphotypeElementsAdditionalValues", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetMusculatureMorphotypeValue(this HumanoidMonsterPresentationDefinition definition, float value)
        {
            definition.SetField("musculatureMorphotypeValue", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetOriginMorphotype(this HumanoidMonsterPresentationDefinition definition, string value)
        {
            definition.SetField("originMorphotype", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetOverrideWieldedItems(this HumanoidMonsterPresentationDefinition definition, bool value)
        {
            definition.SetField("overrideWieldedItems", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetRaceDefinition(this HumanoidMonsterPresentationDefinition definition, CharacterRaceDefinition value)
        {
            definition.SetField("raceDefinition", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetSecondColor(this HumanoidMonsterPresentationDefinition definition, Color value)
        {
            definition.SetField("secondColor", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetSex(this HumanoidMonsterPresentationDefinition definition, CreatureSex value)
        {
            definition.SetField("sex", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetShowHelmet(this HumanoidMonsterPresentationDefinition definition, bool value)
        {
            definition.SetField("showHelmet", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetSkinMorphotype(this HumanoidMonsterPresentationDefinition definition, string value)
        {
            definition.SetField("skinMorphotype", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetSubRaceDefinition(this HumanoidMonsterPresentationDefinition definition, CharacterRaceDefinition value)
        {
            definition.SetField("subRaceDefinition", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetTabardDefinition(this HumanoidMonsterPresentationDefinition definition, string value)
        {
            definition.SetField("tabardDefinition", value);
            return definition;
        }

        public static HumanoidMonsterPresentationDefinition SetThirdColor(this HumanoidMonsterPresentationDefinition definition, Color value)
        {
            definition.SetField("thirdColor", value);
            return definition;
        }
    }
}