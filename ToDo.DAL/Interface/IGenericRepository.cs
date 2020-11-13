using System.Collections.Generic;

namespace ToDo.DataAccess.Interfaces
{
    public interface IGenericRepository<Table> where Table : class
    {
        void Add(Table table);

        void Delete(int id);

        void Update(Table table);

        Table GetById(int id);

        IEnumerable<Table> GetAll();
    }
}
