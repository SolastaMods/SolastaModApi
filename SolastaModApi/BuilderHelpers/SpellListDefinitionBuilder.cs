using SolastaModApi.Extensions;

namespace SolastaModApi.BuilderHelpers
{
    class SpellListDefinitionBuilder : BaseDefinitionBuilder<SpellListDefinition>
    {
        /// <summary>
        /// Example Use
        /// 
        /// new SpellListDefinitionBuilder("demo", "demo", 5, true)
        ///     .ForLevel(1)
        ///         .AddSpell(DemoSpell)
        ///         .AddSpell(SecondSpell)
        ///         .Build()
        ///     .ForLevel(2)
        ///         .AddSpell(BetterSpell)
        /// .AddToDb()
        /// </summary>
        public SpellListDefinitionBuilder(string name, string guid, int maxLevel, bool hasCantrips)
            : base(name, guid)
        {
            Definition.SetHasCantrips(hasCantrips);
            Definition.SetMaxSpellLevel(maxLevel);
        }

        public SpellListLevelBuilder ForLevel(int level)
        {
            return new SpellListLevelBuilder(this, level);
        }

        public class SpellListLevelBuilder
        {
            private SpellListDefinitionBuilder spellListDefinitionBuilder;
            private readonly SpellListDefinition.SpellsByLevelDuplet duplet;

            public SpellListLevelBuilder(SpellListDefinitionBuilder spellListDefinitionBuilder, int level)
            {
                this.spellListDefinitionBuilder = spellListDefinitionBuilder;
                this.duplet = new SpellListDefinition.SpellsByLevelDuplet();
                duplet.Level = level;
                duplet.Spells = new System.Collections.Generic.List<SpellDefinition>();
                spellListDefinitionBuilder.Definition.SpellsByLevel.Add(this.duplet);
            }

            public SpellListLevelBuilder AddSpell(SpellDefinition spell)
            {
                this.duplet.Spells.Add(spell);
                return this;
            }

            public SpellListDefinitionBuilder Build() => spellListDefinitionBuilder;
        }
    }
}
