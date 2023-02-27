using LarningFullStackDomain.Entities;
using System.Collections.Generic;

namespace LarningFullStackDomain.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
    }
}
