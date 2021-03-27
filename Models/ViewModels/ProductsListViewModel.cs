using System.Collections.Generic;
using EvinsEliteSports.Models;
namespace EvinsEliteSports.Models.ViewModels 
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}