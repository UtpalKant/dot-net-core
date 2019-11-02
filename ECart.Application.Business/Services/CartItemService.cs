using ECart.Application.Core.Interfaces;
using ECart.Application.Core.Models.DTO;
using System.Collections.Generic;

namespace ECart.Application.Business.Services
{
    public class CartItemService: ICartItemService
    {
        private readonly IRepositoryService _IRepositoryService;
        public CartItemService(IRepositoryService iRepositoryService)
        {
            _IRepositoryService = iRepositoryService;
        }
        public List<Item> GetItems()
        {
            return _IRepositoryService.GetItems();
        }

    }
}
