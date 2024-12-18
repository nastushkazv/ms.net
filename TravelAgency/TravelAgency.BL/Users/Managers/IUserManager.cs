using TravelAgency.BL.Users.Entity;

namespace TravelAgency.BL.Users.Manager
{
    public interface IUserManager
    {
        UserModel CreateUser(CreateUserModel createModel);
        void DeleteUser(int id);
        UserModel UpdateUser(UpdateUserModel updateModel);
    }
}