using System;
using System.Collections.Generic;
using System.Text;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using ToDo.DataAccess.Interface;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Concrete.EntityFrameworkCore.Repository
{
    public class UrgencyRepository:GenericRepository<Urgency>,IUrgencyRepository
    {
        public UrgencyRepository(ToDoContext context) : base(context)
        {

        }
        public ToDoContext ToDoContext { get { return _context as ToDoContext; } }
    }
}
