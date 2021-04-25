namespace SolastaModApi
{
    public class ClassBuilder : CharacterClassDefinitionBuilder
    {
        // The only change is that the ctor requires name and guid
        public ClassBuilder(string name, string guid) : base(name, guid)
        {
        }

        /*
        private readonly CharacterClassDefinition myClass;

        public ClassBuilder()
        {
            myClass = ScriptableObject.CreateInstance<CharacterClassDefinition>();
        }

        public void SetHitDice(RuleDefinitions.DieType die)
        {
            Traverse.Create(myClass).Field("hitDice").SetValue(die);
        }

        public void SetAbilityScorePriorities(string first, string second, string third, string fourth, string fifth, string sixth)
        {
            myClass.AbilityScoresPriority.Add(first);
            myClass.AbilityScoresPriority.Add(second);
            myClass.AbilityScoresPriority.Add(third);
            myClass.AbilityScoresPriority.Add(fourth);
            myClass.AbilityScoresPriority.Add(fifth);
            myClass.AbilityScoresPriority.Add(sixth);
        }

        public void AddPersonality(PersonalityFlagDefinition personalityType, int weight)
        {
            PersonalityFlagOccurence personality = new PersonalityFlagOccurence();
            Traverse.Create(personality).Field("weight").SetValue(weight);
            Traverse.Create(personality).Field("personalityFlag").SetValue(personalityType.Name);
            myClass.PersonalityFlagOccurences.Add(personality);
        }

        public void AddToolPreference(ToolTypeDefinition toolType)
        {
            myClass.ToolAutolearnPreference.Add(toolType.Name);
        }

        public void AddSkillPreference(SkillDefinition skillType)
        {
            myClass.SkillAutolearnPreference.Add(skillType.Name);
        }

        public void AddExpertisePreference(SkillDefinition skillType)
        {
            myClass.ExpertiseAutolearnPreference.Add(skillType.Name);
        }

        public void AddExpertisePreference(ToolTypeDefinition toolType)
        {
            myClass.ExpertiseAutolearnPreference.Add(toolType.Name);
        }

        public void AddFeatPreference(FeatDefinition featType)
        {
            myClass.FeatAutolearnPreference.Add(featType.Name);
        }

        public void SetIngredientGatheringOdds(int odds)
        {
            Traverse.Create(myClass).Field("ingredientGatheringOdds").SetValue(odds);
        }

        public void SetBattleAI(DecisionPackageDefinition decisionPackage)
        {
            Traverse.Create(myClass).Field("defaultBattleDecisions").SetValue(decisionPackage);
        }

        public void SetPictogram(AssetReferenceSprite sprite)
        {
            Traverse.Create(myClass).Field("classPictogramReference").SetValue(sprite);
        }

        public void SetAnimationId(AnimationDefinitions.ClassAnimationId animId)
        {
            Traverse.Create(myClass).Field("classAnimationId").SetValue(animId);
        }

        public void RequireDeity()
        {
            Traverse.Create(myClass).Field("requiresDeity").SetValue(true);
        }

        public void SetName(string name, string guid)
        {
            Traverse.Create(myClass).Field("name").SetValue(name);
            myClass.name = name;
            Traverse.Create(myClass).Field("guid").SetValue(guid);
        }

        public void SetGuiPresentation(GuiPresentation gui)
        {
            Traverse.Create(myClass).Field("guiPresentation").SetValue(gui);
        }

        public void AddEquipmentRow(List<HeroEquipmentOption> equipmentList)
        {
            HeroEquipmentRow equipmentRow = new HeroEquipmentRow();
            HeroEquipmentColumn equipmentColumn = new HeroEquipmentColumn();
            foreach (HeroEquipmentOption option in equipmentList)
            {
                equipmentColumn.EquipmentOptions.Add(option);
            }
            equipmentRow.EquipmentColumns.Add(equipmentColumn);
            myClass.EquipmentRows.Add(equipmentRow);
        }

        public void AddEquipmentRow(List<HeroEquipmentOption> equipmentListA, List<HeroEquipmentOption> equipmentListB)
        {
            HeroEquipmentRow equipmentRow = new HeroEquipmentRow();
            HeroEquipmentColumn equipmentColumnA = new HeroEquipmentColumn();
            foreach (HeroEquipmentOption option in equipmentListA)
            {
                equipmentColumnA.EquipmentOptions.Add(option);
            }
            equipmentRow.EquipmentColumns.Add(equipmentColumnA);
            HeroEquipmentColumn equipmentColumnB = new HeroEquipmentColumn();
            foreach (HeroEquipmentOption option in equipmentListB)
            {
                equipmentColumnB.EquipmentOptions.Add(option);
            }
            equipmentRow.EquipmentColumns.Add(equipmentColumnB);
            myClass.EquipmentRows.Add(equipmentRow);
        }

        public void AddFeatureAtLevel(FeatureDefinition feature, int level)
        {
            myClass.FeatureUnlocks.Add(new FeatureUnlockByLevel(feature, level));
        }

        public FeatureDefinitionSubclassChoice BuildSubclassChoice(int level, string subclassSuffix, bool requireDeity, string name, GuiPresentation guiPresentation, string guid)
        {
            FeatureDefinitionSubclassChoice subclassChoice = ScriptableObject.CreateInstance<FeatureDefinitionSubclassChoice>();
            Traverse.Create(subclassChoice).Field("filterByDeity").SetValue(requireDeity);
            Traverse.Create(subclassChoice).Field("subclassSuffix").SetValue(subclassSuffix);
            Traverse.Create(subclassChoice).Field("name").SetValue(name);
            subclassChoice.name = name;
            Traverse.Create(subclassChoice).Field("guiPresentation").SetValue(guiPresentation);
            Traverse.Create(subclassChoice).Field("guid").SetValue(guid);

            DatabaseRepository.GetDatabase<FeatureDefinition>().Add(subclassChoice);
            AddFeatureAtLevel(subclassChoice, level);
            return subclassChoice;
        }

        public CharacterClassDefinition AddToDB()
        {
            Database<CharacterClassDefinition> CharacterClassDatabase = DatabaseRepository.GetDatabase<CharacterClassDefinition>();
            // add new class to db
            CharacterClassDatabase.Add(myClass);
            return myClass;
        }
        */
    }
}
