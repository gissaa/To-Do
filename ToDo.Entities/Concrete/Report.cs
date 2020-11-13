using ToDo.Entities.Interfaces;

namespace ToDo.Entities.Concrete
{
    public class Report:ITable
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public string Description { get; set; }
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
    }
}
