using System.Collections.Generic;
using ToDo.Entities.Interfaces;

namespace ToDo.Entities.Concrete
{
    public class Urgency:ITable
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public List<Assignment> Assignments { get; set; }
        
    }
}
