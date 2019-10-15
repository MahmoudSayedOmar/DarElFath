using DarElFathElEslamy.Academy.Domain.Models;
using DarElFathElEslamy.Academy.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarElFathElEslamy.Academy.Domain.Services
{
    public class AuthenticationService
    {
        private readonly IRepository<User> _userRepository;

        public AuthenticationService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }
        public User Add (User user)
        {
            if (user == null)
            throw new ArgumentNullException(nameof(user));
            //var users = _userRepository.GetAll().ToList();
            DataModelValidator.Validate(user);
            _userRepository.Add(user);
            _userRepository.UOF.Commit();
            return user;
        }

        public User GetUser(String Email)
        {
            if (Email == null)
                throw new ArgumentException();

            return _userRepository.GetAll()
                .FirstOrDefault(user => user.Email == Email);
        }

        public void Modify(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(User));

            if (user.Id < 1)
                throw new ArgumentException();

            DataModelValidator.Validate(user);

            _userRepository.Modify(user);
            _userRepository.UOF.Commit();
        }


        public IQueryable<User> GetAll()
        {
            return _userRepository.GetAll();
        }
    }
}

