using System;
using System.Collections.Generic;
using System.Text;
using ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using ToDo.DataAccess.Interfaces;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Interface
{
    public interface IReportRepository : IGenericRepository<Report>
    {

    }
}
