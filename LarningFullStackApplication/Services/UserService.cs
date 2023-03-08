using AutoMapper;
using LarningFullStackApplication.Interfaces;
using LarningFullStackApplication.ViewModels;
using LarningFullStackDomain.Entities;
using LarningFullStackDomain.Interfaces;
using System.Collections.Generic;

namespace LarningFullStackApplication.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public List<UserViewModel> Get()
        {
            var _users = this.userRepository.GetAll();

            var _userViewModels = mapper.Map<List<UserViewModel>>(_users);

            return _userViewModels;
        }

        public bool Post(UserViewModel userViewModel)
        {

            User _user = mapper.Map<User>(userViewModel);

            this.userRepository.Create(_user);

            return true;
        }
    }
}
