using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.Business.Interface
{
    public interface IGenericService<Table> where Table:class
    {
        void Add(Table table);
        void Delete(int id);

        void Update(Table table);

        Table GetById(int id);

        IEnumerable<Table> GetAll();
    }
}
