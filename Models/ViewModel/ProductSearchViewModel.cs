using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList;
using PagedList.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Models.ViewModel
{
    public class ProductSearchViewModel
    {
        public string SearchTerm { get; set; }

        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        public string SortOrder { get; set; }

        public int PageNumber { get; set; } 
        public int PageSize { get; set; } = 10; 
        public PagedList.IPagedList<Product> Products { get; set; }
    }
}