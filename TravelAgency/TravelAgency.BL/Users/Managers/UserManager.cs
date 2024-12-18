using AutoMapper;
using TravelAgency.BL.Users.Entity;
using TravelAgency.BL.Users.Exceptions;
using TravelAgency.DataAccess.Entities;
using TravelAgency.Repository;

namespace TravelAgency.BL.Users.Manager
{
    public class UsersManager : IUserManager
    {
        private readonly IRepository<UserEntity> _usersRepository;
        private readonly IMapper _mapper;

        public UsersManager(IRepository<UserEntity> usersRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _mapper = mapper;
        }

        public UserModel CreateUser(CreateUserModel createModel)
        {
            if (string.IsNullOrEmpty(createModel.Login) || string.IsNullOrEmpty(createModel.PasswordHash))
            {
                throw new ArgumentException("Login and PasswordHash are required.");
            }

            UserEntity entity;
            if (createModel.Role == "Visitor")
            {
                entity = _mapper.Map<VisitorEntity>(createModel);
            }
            else if (createModel.Role == "Employee")
            {
                entity = _mapper.Map<EmployeeEntity>(createModel);
            }
            else
            {
                throw new ArgumentException("Invalid role.");
            }
            
            entity = _usersRepository.Save(entity);
            return _mapper.Map<UserModel>(entity);
        }

        public void DeleteUser(int id)
        {
            var entity = _usersRepository.GetById(id);
            if (entity == null)
            {
                throw new UserNotFoundException($"User with ID {id} not found.");
            }
            
            _usersRepository.Delete(entity);
        }

        public UserModel UpdateUser(UpdateUserModel updateModel)
        {
            if (updateModel.Id <= 0)
            {
                throw new ArgumentException("Invalid user ID.");
            }

            UserEntity entity;
            if (updateModel.Role == "Visitor")
            {
                entity = _mapper.Map<VisitorEntity>(updateModel);
            }
            else if (updateModel.Role == "Employee")
            {
                entity = _mapper.Map<EmployeeEntity>(updateModel);
            }
            else
            {
                throw new ArgumentException("Invalid role.");
            }
            
            entity = _usersRepository.Save(entity);
            return _mapper.Map<UserModel>(entity);
        }
    }
}