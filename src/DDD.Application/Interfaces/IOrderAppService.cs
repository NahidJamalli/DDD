using System;
using System.Collections.Generic;
using DDD.Application.ViewModels;
using DDD.Domain.Commands.Order;

namespace DDD.Application.Interfaces
{
    public interface IOrderAppService : IDisposable
    {
        void Add(OrderDto newOrder);
        void Delete(Guid id);
        List<OrderViewModel> GetOrders(int skip, int take);
    }
}
