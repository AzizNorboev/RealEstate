using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Features
{
    public class MetaData
    {
        //required properties for the pagination
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }

        public bool HasPrevious => CurrentPage > 1;
        public bool HasNext => CurrentPage < TotalPages;
    }
}
