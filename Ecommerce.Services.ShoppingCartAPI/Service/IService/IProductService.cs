using Ecommerce.Services.ShoppingCartAPI.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ecommerce.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
