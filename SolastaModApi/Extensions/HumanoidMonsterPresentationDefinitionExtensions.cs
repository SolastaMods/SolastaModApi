using SolastaModApi.Infrastructure;
using UnityEngine;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class HumanoidMonsterPresentationDefinitionExtensions
    {
        public static T SetAgeMorphotypeValue<T>(this T entity, float value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("ageMorphotypeValue", value);
            return entity;
        }

        public static T SetArmorDefinition<T>(this T entity, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("armorDefinition", value);
            return entity;
        }

        public static T SetBeardShapeMorphotype<T>(this T entity, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("beardShapeMorphotype", value);
            return entity;
        }

        public static T SetBodyDecorationMorphotype<T>(this T entity, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("bodyDecorationMorphotype", value);
            return entity;
        }

        public static T SetEyeColorMorphotype<T>(this T entity, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("eyeColorMorphotype", value);
            return entity;
        }

        public static T SetFaceShapeMorphotype<T>(this T entity, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("faceShapeMorphotype", value);
            return entity;
        }

        public static T SetFirstColor<T>(this T entity, Color value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("firstColor", value);
            return entity;
        }

        public static T SetFourthColor<T>(this T entity, Color value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("fourthColor", value);
            return entity;
        }

        public static T SetHairColorMorphotype<T>(this T entity, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("hairColorMorphotype", value);
            return entity;
        }

        public static T SetHairShapeMorphotype<T>(this T entity, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("hairShapeMorphotype", value);
            return entity;
        }

        public static T SetHasMonsterPortraitBackground<T>(this T entity, bool value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("hasMonsterPortraitBackground", value);
            return entity;
        }

        public static T SetHelmetDefinition<T>(this T entity, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("helmetDefinition", value);
            return entity;
        }

        public static T SetItemDefinitionMainHand<T>(this T entity, ItemDefinition value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("itemDefinitionMainHand", value);
            return entity;
        }

        public static T SetItemDefinitionOffHand<T>(this T entity, ItemDefinition value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("itemDefinitionOffHand", value);
            return entity;
        }

        public static T SetMusculatureMorphotypeValue<T>(this T entity, float value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("musculatureMorphotypeValue", value);
            return entity;
        }

        public static T SetOriginMorphotype<T>(this T entity, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("originMorphotype", value);
            return entity;
        }

        public static T SetOverrideWieldedItems<T>(this T entity, bool value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("overrideWieldedItems", value);
            return entity;
        }

        public static T SetRaceDefinition<T>(this T entity, CharacterRaceDefinition value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("raceDefinition", value);
            return entity;
        }

        public static T SetSecondColor<T>(this T entity, Color value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("secondColor", value);
            return entity;
        }

        public static T SetSex<T>(this T entity, CreatureSex value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("sex", value);
            return entity;
        }

        public static T SetShowHelmet<T>(this T entity, bool value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("showHelmet", value);
            return entity;
        }

        public static T SetSkinMorphotype<T>(this T entity, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("skinMorphotype", value);
            return entity;
        }

        public static T SetSubRaceDefinition<T>(this T entity, CharacterRaceDefinition value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("subRaceDefinition", value);
            return entity;
        }

        public static T SetTabardDefinition<T>(this T entity, string value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("tabardDefinition", value);
            return entity;
        }

        public static T SetThirdColor<T>(this T entity, Color value)
            where T : HumanoidMonsterPresentationDefinition
        {
            entity.SetField("thirdColor", value);
            return entity;
        }
    }
}