using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAppX.Models;

namespace ToDoAppX.Repositories
{
    public interface IGeneralRepository<Type>
    {
        void Create(Type element);
        List<Type> Read();
        void Delete(Type element);
        void Edit(Type element);

        Type GetRecordById(long id);
    }
}
