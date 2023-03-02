using LarningFullStackDomain.Entities;
using System.Collections.Generic;

namespace LarningFullStackDomain.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        IEnumerable<User> GetAll();
    }
}
