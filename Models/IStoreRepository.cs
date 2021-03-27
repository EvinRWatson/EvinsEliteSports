using System.Linq;

namespace EvinsEliteSports.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
