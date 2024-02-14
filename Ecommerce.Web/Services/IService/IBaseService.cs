using Ecommerce.Web.Models;

namespace Ecommerce.Web.Services.IService
{
    public interface IBaseService
    {
        Task<ResponseDto> SendAsync(ResponseDto responseDto);
        Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
