using SolastaModApi.Infrastructure;
using UnityEngine;
using System.Collections.Generic;
using static RuleDefinitions;
using static MorphotypeElementDefinition;

namespace SolastaModApi
{
    public static class HumanoidMonsterPresentationDefinitionExtensions
    {
        public static T SetAgeMorphotypeValue<T>(this T definition, float value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("ageMorphotypeValue", value);
            return definition;
        }

        public static T SetArmorDefinition<T>(this T definition, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("armorDefinition", value);
            return definition;
        }

        public static T SetBeardShapeMorphotype<T>(this T definition, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("beardShapeMorphotype", value);
            return definition;
        }

        public static T SetBodyDecorationMorphotype<T>(this T definition, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("bodyDecorationMorphotype", value);
            return definition;
        }

        public static T SetEyeColorMorphotype<T>(this T definition, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("eyeColorMorphotype", value);
            return definition;
        }

        public static T SetFaceShapeMorphotype<T>(this T definition, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("faceShapeMorphotype", value);
            return definition;
        }

        public static T SetFirstColor<T>(this T definition, Color value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("firstColor", value);
            return definition;
        }

        public static T SetFourthColor<T>(this T definition, Color value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("fourthColor", value);
            return definition;
        }

        public static T SetHairColorMorphotype<T>(this T definition, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("hairColorMorphotype", value);
            return definition;
        }

        public static T SetHairShapeMorphotype<T>(this T definition, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("hairShapeMorphotype", value);
            return definition;
        }

        public static T SetHasMonsterPortraitBackground<T>(this T definition, bool value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("hasMonsterPortraitBackground", value);
            return definition;
        }

        public static T SetHelmetDefinition<T>(this T definition, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("helmetDefinition", value);
            return definition;
        }

        public static T SetItemDefinitionMainHand<T>(this T definition, ItemDefinition value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("itemDefinitionMainHand", value);
            return definition;
        }

        public static T SetItemDefinitionOffHand<T>(this T definition, ItemDefinition value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("itemDefinitionOffHand", value);
            return definition;
        }

        public static T SetMorphotypeElements<T>(this T definition, Dictionary<ElementCategory, string> value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("morphotypeElements", value);
            return definition;
        }

        public static T SetMorphotypeElementsAdditionalValues<T>(this T definition, Dictionary<ElementCategory, float> value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("morphotypeElementsAdditionalValues", value);
            return definition;
        }

        public static T SetMusculatureMorphotypeValue<T>(this T definition, float value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("musculatureMorphotypeValue", value);
            return definition;
        }

        public static T SetOriginMorphotype<T>(this T definition, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("originMorphotype", value);
            return definition;
        }

        public static T SetOverrideWieldedItems<T>(this T definition, bool value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("overrideWieldedItems", value);
            return definition;
        }

        public static T SetRaceDefinition<T>(this T definition, CharacterRaceDefinition value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("raceDefinition", value);
            return definition;
        }

        public static T SetSecondColor<T>(this T definition, Color value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("secondColor", value);
            return definition;
        }

        public static T SetSex<T>(this T definition, CreatureSex value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("sex", value);
            return definition;
        }

        public static T SetShowHelmet<T>(this T definition, bool value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("showHelmet", value);
            return definition;
        }

        public static T SetSkinMorphotype<T>(this T definition, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("skinMorphotype", value);
            return definition;
        }

        public static T SetSubRaceDefinition<T>(this T definition, CharacterRaceDefinition value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("subRaceDefinition", value);
            return definition;
        }

        public static T SetTabardDefinition<T>(this T definition, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("tabardDefinition", value);
            return definition;
        }

        public static T SetThirdColor<T>(this T definition, Color value)
            where T : HumanoidMonsterPresentationDefinition
        {
            definition.SetField("thirdColor", value);
            return definition;
        }
    }
}