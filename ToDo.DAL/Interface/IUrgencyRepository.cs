using System;
using System.Collections.Generic;
using System.Text;
using ToDo.DataAccess.Interfaces;
using ToDo.Entities.Concrete;

namespace ToDo.DataAccess.Interface
{
    public interface IUrgencyRepository:IGenericRepository<Urgency>
    {
    }
}
