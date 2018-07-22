using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseApp.Repositories
{
    public interface IGenericRepository<Type>
    {
        void Create(Type element);
        List<Type> Read();
        void Update(Type element);
        void Delete(Type element);
    }
}
