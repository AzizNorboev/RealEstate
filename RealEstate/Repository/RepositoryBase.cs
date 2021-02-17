using Entities;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
