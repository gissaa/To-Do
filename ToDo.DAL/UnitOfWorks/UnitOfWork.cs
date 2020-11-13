
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Repository;
using ToDo.DataAccess.Interface;
using ToDo.DataAccess.Interfaces;

namespace ToDo.DataAccess.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private ToDoContext _context;
        public UnitOfWork(ToDoContext context)
        {
            _context = context;
            AssignmentRepository = new AssignmentRepository(_context);
            UrgencyRepository = new UrgencyRepository(_context);
        }

        public IAssignmentRepository AssignmentRepository { get;  }

        public IUrgencyRepository UrgencyRepository { get; }


        

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
