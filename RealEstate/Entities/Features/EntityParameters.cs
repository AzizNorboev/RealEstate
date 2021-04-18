using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Features
{
    //This class is a container for the actual parameters
    public class EntityParameters
    {
        const int maxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int _pageSize = 4;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {//limiting the highest value to the max page size value
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }

        //properties for searching and sorting
        //implementation is in RepoExtention classes in Extentions folder
        public string SearchTerm { get; set; }
        public string OrderBy { get; set; } = "status";
    }
}
