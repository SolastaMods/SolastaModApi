using System;

namespace SolastaModApi
{
    public class CharacterSubclassDefinitionBuilder : BaseDefinitionBuilder<CharacterSubclassDefinition>
    {
        public CharacterSubclassDefinitionBuilder(string name, string guid) : base(name, guid)
        {
        }

        public CharacterSubclassDefinitionBuilder(string name, Guid guidNamespace) : base(name, guidNamespace)
        {
        }

        public CharacterSubclassDefinitionBuilder SetGuiPresentation(GuiPresentation gui)
        {
            Definition.SetGuiPresentation(gui);
            return this;
        }

        public CharacterSubclassDefinitionBuilder AddPersonality(PersonalityFlagDefinition personalityType, int weight)
        {
            Definition.PersonalityFlagOccurences.Add(PersonalityFlagOccurenceExtensions.Create(weight, personalityType.Name));
            return this;
        }

        public CharacterSubclassDefinitionBuilder AddFeatureAtLevel(FeatureDefinition feature, int level)
        {
            Definition.FeatureUnlocks.Add(new FeatureUnlockByLevel(feature, level));
            return this;
        }
    }
}
