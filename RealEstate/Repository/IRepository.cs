using Entities.Features;
using Repository.Pagination;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{

    public interface IRepository<T>
    {
        
        Task<PagedList<T>> GetAll(EntityParameters entityParameters);
        Task<T> GetById(int id);

        Task Create(T entity);
        Task Update(T entity, T dbEntity);
        Task Delete(int id);
    }
}
