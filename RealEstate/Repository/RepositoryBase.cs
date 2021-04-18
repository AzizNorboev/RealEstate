using Entities;

namespace Repository
{
    public abstract class RepositoryBase
    {
        protected RepoContext _context { get; set; }

        public RepositoryBase(RepoContext context)
        {
            _context = context;
        }


    }


}
