using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Business.Interface;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using ToDo.DataAccess.Interfaces;
using ToDo.DataAccess.UnitOfWorks;
using ToDo.Entities.Concrete;

namespace ToDo.Business.Concrete
{
    public class AssignmentManager : IAssignmentService
    {
        public IAssignmentRepository assignmentRepository { get; private set; }
        UnitOfWork unitOfWork = new UnitOfWork(new ToDoContext());
        private ToDoContext _context;
        public AssignmentManager(ToDoContext context)
        {
            _context = context;
            assignmentRepository = new AssignmentRepository(_context);
        }
        public void Add(Assignment table)
        {
            assignmentRepository.Add(table);
            unitOfWork.Complete();
        }

        public void Delete(int id)
        {
            assignmentRepository.Delete(id);
        }

        public IEnumerable<Assignment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Assignment GetById(int id)
        {
           return assignmentRepository.GetById(id);
        }

        public void Update(Assignment table)
        {
            assignmentRepository.Update(table);
        }
    }
}
