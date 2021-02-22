using Entities.Features;
using RealEstate.Client.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Client.HttpRepository
{
    public interface IPropertyHttpRepository<T> where T : class
    {
        //Task<List<T>> GetProperty();
        Task<PagingResponse<T>> GetProperty(EntityParameters entityParameters);
    }
}
