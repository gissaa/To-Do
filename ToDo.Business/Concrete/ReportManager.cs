using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Business.Interface;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Repository;
using ToDo.DataAccess.Interface;
using ToDo.Entities.Concrete;

namespace ToDo.Business.Concrete
{
    public class ReportManager : IReportService
    {
        public IReportRepository ReportRepository { get; private set; }

        private ToDoContext _context;
        public ReportManager(ToDoContext context)
        {
            _context = context;
            ReportRepository = new ReportRepository(_context);
        }
        public void Add(Report table)
        {
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Report> GetAll()
        {
            throw new NotImplementedException();
        }

        public Report GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Report table)
        {
            throw new NotImplementedException();
        }
    }
}
