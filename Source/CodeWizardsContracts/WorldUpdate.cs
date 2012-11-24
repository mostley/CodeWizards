namespace CodeWizards.Contracts
{
    using System.Collections.Generic;

    public class WorldUpdate
    {
        public List<SpellInstance> ActiveSpells { get; set; }
        public List<Entity> LastDelvedEntities { get; set; }
    }
}