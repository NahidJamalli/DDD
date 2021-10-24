using System.Collections.Generic;
using DDD.Domain.Models;

namespace DDD.Domain.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        List<Order> GetAllPaginated(int skip, int take);
    }
}
