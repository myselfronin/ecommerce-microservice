using Ecommerce.Services.ShoppingCartAPI.Models.Dto;
using System.Threading.Tasks;

namespace Ecommerce.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}