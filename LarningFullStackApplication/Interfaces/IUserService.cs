using LarningFullStackApplication.ViewModels;
using System.Collections.Generic;

namespace LarningFullStackApplication.Interfaces
{
    public interface IUserService
    {
        List<UserViewModel> Get();
    }
}
