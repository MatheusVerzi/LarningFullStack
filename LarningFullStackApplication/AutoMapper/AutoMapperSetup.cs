using AutoMapper;
using LarningFullStackApplication.ViewModels;
using LarningFullStackDomain.Entities;

namespace LarningFullStackApplication.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {

            #region ViewModelToDomain
            CreateMap<UserViewModel, User>();
            #endregion

            #region DomainToViewModel
            CreateMap<User, UserViewModel>();

            #endregion
        }
    }
}
