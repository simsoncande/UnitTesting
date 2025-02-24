using UnitTestPOC.BusinessObjects;

namespace UnitTestPOC.Services.Interface
{
    public interface IUserManager
    {
        Task<List<User>> ListAllUser();
        Task<User> GetUser(int id);
    }
}
