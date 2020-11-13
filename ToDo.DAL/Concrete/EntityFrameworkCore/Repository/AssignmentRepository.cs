using ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using ToDo.DataAccess.Interfaces;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class AssignmentRepository :GenericRepository<Assignment>, IAssignmentRepository
    {
        public AssignmentRepository(ToDoContext context) : base(context)
        {

        }
        public ToDoContext ToDoContext { get { return _context as ToDoContext; } }
    }
}
