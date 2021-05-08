using SolastaModApi.Diagnostics;
using SolastaModApi.Infrastructure;
using SolastaTesting.SolastaModApi;
using System;
using UnityEngine;

namespace SolastaModApi
{
    /// <summary>
    ///     Base class builder for all classes derived from BaseDefinition
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseDefinitionBuilder<T> where T : BaseDefinition
    {
        /// <summary>
        /// Create a new one
        /// </summary>
        /// <param name="name"></param>
        /// <param name="guid"></param>
        protected BaseDefinitionBuilder(string name, string guid)
        {
            Preconditions.IsNotNullOrWhiteSpace(name, nameof(name));
            Preconditions.IsNotNullOrWhiteSpace(guid, nameof(guid));

            Definition = ScriptableObject.CreateInstance<T>();

            Definition.name = name;
            Definition.SetField("guid", guid);
        }

        /// <summary>
        /// Create a new one
        /// </summary>
        /// <param name="name"></param>
        /// <param name="guidNamespace"></param>
        protected BaseDefinitionBuilder(string name, Guid guidNamespace) :
            this(name, GuidHelper.Create(guidNamespace, name).ToString("N"))
        {
        }

        /// <summary>
        /// Create clone and rename
        /// </summary>
        /// <param name="original"></param>
        /// <param name="name"></param>
        /// <param name="guid"></param>
        protected BaseDefinitionBuilder(T original, string name, string guid)
        {
            Preconditions.IsNotNullOrWhiteSpace(name, nameof(name));
            Preconditions.IsNotNullOrWhiteSpace(guid, nameof(guid));

            Definition = UnityEngine.Object.Instantiate(original);

            Definition.name = name;
            Definition.SetField("guid", guid);
        }

        /// <summary>
        /// Create clone and rename
        /// </summary>
        /// <param name="original"></param>
        /// <param name="name"></param>
        /// <param name="guidNamespace"></param>
        protected BaseDefinitionBuilder(T original, string name, Guid guidNamespace) :
            this(original, name, GuidHelper.Create(guidNamespace, name).ToString("N"))
        {
        }

        /// <summary>
        /// Take ownership
        /// </summary>
        /// <param name="original"></param>
        protected BaseDefinitionBuilder(T original)
        {
            Definition = original;
        }

        private static void AddToDB<TDb>(TDb definition, bool assertIfDuplicate = true) where TDb : BaseDefinition
        {
            Preconditions.IsNotNull(definition, nameof(definition));
            Preconditions.IsNotNullOrWhiteSpace(definition.Name, "definition.Name");
            Preconditions.IsNotNullOrWhiteSpace(definition.GUID, "definition.GUID");

            var db = DatabaseRepository.GetDatabase<TDb>();

            Assert.IsNotNull(db, $"Database '{typeof(TDb).Name}' not found.");

            if (assertIfDuplicate && (db.HasElement(definition.name) || db.HasElementByGuid(definition.GUID)))
                throw new SolastaModApiException(
                    $"The definition with name '{definition.name}' already exists in database '{typeof(TDb).Name}'");

            db.Add(definition);
        }

        /// <summary>
        /// Some types are added to multiple databases.  For example:
        /// FeatureDefinitionAbilityCheckAffinity is a FeatureDefinitionAffinity is a FeatureDefinition
        /// so an instance of FeatureDefinitionAbilityCheckAffinity should be added to these three databases.
        /// </summary>
        /// <typeparam name="TDb"></typeparam>
        /// <param name="assertIfDuplicate"></param>
        private void AddToDBIfMatch<TDb>(bool assertIfDuplicate = true)
            where TDb : BaseDefinition
        {
            if(Definition is TDb)
            {
                AddToDB(Definition as TDb, assertIfDuplicate);
            }
        }

        public T AddToDB(bool assertIfDuplicate = true)
        {
            if (Definition is RecordTableDefinition)
            {
                AddToDBIfMatch<RecordTableDefinition>(assertIfDuplicate);
                AddToDBIfMatch<AdventureLogDefinition>(assertIfDuplicate);
                AddToDBIfMatch<BestiaryStatsDefinition>(assertIfDuplicate);
                AddToDBIfMatch<BestiaryTableDefinition>(assertIfDuplicate);
                AddToDBIfMatch<ConsoleTableDefinition>(assertIfDuplicate);
                AddToDBIfMatch<DailyLogDefinition>(assertIfDuplicate);
                AddToDBIfMatch<DocumentTableDefinition>(assertIfDuplicate);
                AddToDBIfMatch<TravelJournalDefinition>(assertIfDuplicate);
                AddToDBIfMatch<TutorialTableDefinition>(assertIfDuplicate);
                AddToDBIfMatch<TutorialTocDefinition>(assertIfDuplicate);
            }
            else if (Definition is FeatureDefinition)
            {
                AddToDBIfMatch<FeatureDefinition>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionActionAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionAdditionalAction>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionAdditionalDamage>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionAttributeModifier>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionAutoPreparedSpells>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionBonusCantrips>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionCastSpell>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionCharacterPresentation>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionCriticalCharacter>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionFactionAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionFactionChange>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionFeatureSet>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionFightingStyleChoice>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionLightSource>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionLoreExpertise>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionMovementAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionMoveMode>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionPointPool>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionPower>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionProficiency>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionSchoolSavant>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionSense>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionSocialAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionSubclassChoice>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionAbilityCheckAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionAttackModifier>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionCampAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionCombatAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionConditionAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionCraftingAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionDamageAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionDeathSavingThrowAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionDieRollModifier>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionEquipmentAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionHealingModifier>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionLanguageAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionLightAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionMagicAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionMoveThroughEnemyModifier>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionPerceptionAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionRegeneration>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionSavingThrowAffinity>(assertIfDuplicate);
                AddToDBIfMatch<FeatureDefinitionTerrainTypeAffinity>(assertIfDuplicate);
            }
            else if (Definition is BaseBlueprint)
            {
                AddToDBIfMatch<BaseBlueprint>(assertIfDuplicate);
                AddToDBIfMatch<FurnitureBlueprint>(assertIfDuplicate);
                AddToDBIfMatch<RoomBlueprint>(assertIfDuplicate);
                AddToDBIfMatch<GadgetBlueprint>(assertIfDuplicate);
                AddToDBIfMatch<PropBlueprint>(assertIfDuplicate);
            }
            else if (Definition is EditableGraphDefinition)
            {
                AddToDBIfMatch<EditableGraphDefinition>(assertIfDuplicate);
                AddToDBIfMatch<NarrativeTreeDefinition>(assertIfDuplicate);
                AddToDBIfMatch<QuestTreeDefinition>(assertIfDuplicate);
            }
            else
            {
                AddToDB(Definition, assertIfDuplicate);
            }

            return Definition;
        }

        protected T Definition { get; }
    }
}