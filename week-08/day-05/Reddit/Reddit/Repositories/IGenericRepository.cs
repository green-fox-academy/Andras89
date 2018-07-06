using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Repositories
{
    public interface IGenericRepository<Type>
    {
        void Add(Type element);
        List<Type> Read();
        void Update(Type element);
        void Delete(Type element);
    }
}
