using System;
using ToDo.DataAccess.Interface;
using ToDo.DataAccess.Interfaces;

namespace ToDo.DataAccess.UnitOfWorks
{
    public interface IUnitOfWork:IDisposable
    {
        IAssignmentRepository AssignmentRepository { get; }
        IUrgencyRepository UrgencyRepository { get; }
        int Complete();
    }
}
