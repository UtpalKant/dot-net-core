using ECart.Application.Core.Models.DTO;

namespace ECart.Application.Core.Interfaces
{
    public interface ILoginService
    {
        Token GetToken(string userName, string password);
    }
}
