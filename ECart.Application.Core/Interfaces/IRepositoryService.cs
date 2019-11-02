using ECart.Application.Core.Models.DTO;
using System.Collections.Generic;

namespace ECart.Application.Core.Interfaces
{
    public interface IRepositoryService
    {
        Token GetToken(string userName, string password);
        List<Item> GetItems();
    }
}
