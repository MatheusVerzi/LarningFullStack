using LarningFullStackApplication.Interfaces;
using LarningFullStackApplication.ViewModels;
using LarningFullStackDomain.Entities;
using LarningFullStackDomain.Interfaces;
using System;
using System.Collections.Generic;

namespace LarningFullStackApplication.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<UserViewModel> Get()
        {
            var cagada = new List<UserViewModel>();
            IEnumerable<User> _users = this.userRepository.GetAll();
            foreach (var user in _users)
                cagada.Add(
                    new UserViewModel
                    {
                        Id = user.Id,
                        Name = user.Name,
                        Email = user.Email,
                    });

            return cagada;
        }

        public bool Post(UserViewModel userViewModel)
        {
            User user = new User
            {
                Id = Guid.NewGuid(),
                Email = userViewModel.Email,
                Name = userViewModel.Name,

            };

            this.userRepository.Create(user);

            return true;
        }
    }
}
