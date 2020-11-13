using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Business.Interface;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Repository;
using ToDo.DataAccess.Interface;
using ToDo.DataAccess.UnitOfWorks;
using ToDo.Entities.Concrete;

namespace ToDo.Business.Concrete
{
    public class UrgencyManager : IUrgencyService
    {
        public IUrgencyRepository urgencyRepository { get; private set; }
        private ToDoContext _context;
        UnitOfWork UnitOfWork = new UnitOfWork(new ToDoContext());
        public UrgencyManager(ToDoContext context)
        {
            _context = context;
            urgencyRepository = new UrgencyRepository(_context);
        }
        public void Add(Urgency table)
        {
            UnitOfWork.UrgencyRepository.Add(table);
            UnitOfWork.Complete();
        }

        public void Delete(int id)
        {
            UnitOfWork.UrgencyRepository.Delete(id);
            UnitOfWork.Complete();
            
        }

        public IEnumerable<Urgency> GetAll()
        {
            return urgencyRepository.GetAll();
        }

        public Urgency GetById(int id)
        {
            return urgencyRepository.GetById(id);
        }

        public void Update(Urgency table)
        {
            UnitOfWork.UrgencyRepository.Update(table);
            UnitOfWork.Complete();
        }
    }
}
