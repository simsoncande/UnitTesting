using System.Data;
using UnitTestPOC.BusinessObjects;
using UnitTestPOC.Services.Interface;

namespace UnitTestPOC.Services.Class
{
    public class UserManager : IUserManager
    {
        public async Task<User> GetUser(int id)
        {


            User user = new User();
            var result = new List<User>
            {
                new User{
                Email = "mich@gmail.com",
                Name = "mich",
                Id = 1
                },
                new User
                {
                Email = "michael@gmail.com",
                Name = "michael",
                Id = 2
                }
            };
            user = result.Where(x => x.Id == id).FirstOrDefault();


            return user;

        }
        public async Task<List<User>> ListAllUser()
        {

            List<User> result;

            result = new List<User>
            {
                new User{
                Email = "mich@gmail.com",
                Name = "mich",
                Id = 1
                },
                new User
                {
                Email = "michael@gmail.com",
                Name = "michael",
                Id = 2
                }
            };
            return result;

        }
    }
}
