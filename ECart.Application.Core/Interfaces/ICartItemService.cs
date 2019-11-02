using ECart.Application.Core.Models.DTO;
using System.Collections.Generic;

namespace ECart.Application.Core.Interfaces
{
    public interface ICartItemService
    {
        List<Item> GetItems();
    }
}
