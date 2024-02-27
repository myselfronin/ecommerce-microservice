using Ecommerce.Services.Web.Models.Dto;
using Ecommerce.Web.Models;

namespace Ecommerce.Web.Services.IService
{
    public interface IOrderService
    {
        Task<ResponseDto?> CreateOrder(CartDto cart);

        Task<ResponseDto?> GetAllOrder(string? userId);

        Task<ResponseDto?> GetOrder(int orderId);
        Task<ResponseDto?> UpdateOrderStatus(int orderId, string newStatus);
    }
}
