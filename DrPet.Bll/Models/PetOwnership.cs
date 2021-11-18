using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrPet.Bll.Models
{
    public class PetOwnership
    {
        public int Id { get; set; }
        public int PetId { get; set; }
        public int OwnerId { get; set; }
    }
}
