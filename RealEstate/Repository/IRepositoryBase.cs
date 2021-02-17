using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepositoryBase<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);

        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);

    }
}
