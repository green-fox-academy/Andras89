using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Repository
{
    public interface IGenericRepository<Type>
    {
        void Create(Type element);
        List<Type> Read();
    }
}
