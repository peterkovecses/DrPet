using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrPet.Bll.Models
{
    public record Consulting(int Id, DateTime StartOfConsulting, DateTime EndOfConsulting, int WorkerId, string WorkerName) { }
}
