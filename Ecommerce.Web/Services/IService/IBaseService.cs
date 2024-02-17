using Ecommerce.Web.Models;

namespace Ecommerce.Web.Services.IService
{
    public interface IBaseService
    {        Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true);
    }
}
