using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.HttpRepository
{
    public interface IPropertyHttpRepository<T> where T : class
    {
        Task<List<T>> GetProperty();
    }
}
