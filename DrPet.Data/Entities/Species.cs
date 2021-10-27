using System.Collections.Generic;

namespace DrPet.Data.Entities
{
    public class Species : EntityBase<Species>
    {
        public string Name { get; set; }
        public string LatinName { get; set; }

        public ICollection<Variety> Varieties { get; set; }
    }
}