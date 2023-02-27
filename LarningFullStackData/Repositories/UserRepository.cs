using LarningFullStackDomain.Entities;
using LarningFullStackDomain.Interfaces;
using LarningFullStackInfra.Context;
using System.Collections.Generic;

namespace LarningFullStackData.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {

        public UserRepository(AppDbContext context)
            : base(context) { }

        public IEnumerable<User> GetAll()
        {
            return Query(x => !x.IsDeleted);
        }

    }
}
