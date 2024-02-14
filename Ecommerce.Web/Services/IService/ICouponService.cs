using Ecommerce.Web.Models;

namespace Ecommerce.Web.Services.IService
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsyc(string couponCode);
        Task<ResponseDto?> GetAllCouponAsyc();
        Task<ResponseDto?> GetCouponByIdAsyc(int couponId);
        Task<ResponseDto?> CreateCouponAsyc(CouponDto couponDto);
        Task<ResponseDto?> UpdateCouponAsyc(CouponDto couponDto);
        Task<ResponseDto?> DeleteCouponAsyc(int id);
    }
}
