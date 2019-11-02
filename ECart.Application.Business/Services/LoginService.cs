using ECart.Application.Core.Interfaces;
using ECart.Application.Core.Models.DTO;

namespace ECart.Application.Business.Services
{
    public class LoginService: ILoginService
    {
        private readonly IRepositoryService _IRepositoryService;
        public LoginService(IRepositoryService iRepositoryService)
        {
            _IRepositoryService = iRepositoryService;
        }
        public Token GetToken(string userName, string password)
        {
            return _IRepositoryService.GetToken(userName, password);
        }
    }
}
