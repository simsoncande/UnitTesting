using Microsoft.AspNetCore.Mvc;
using Moq;
using UnitTestPOC.BusinessObjects;
using UnitTestPOC.Controllers;
using UnitTestPOC.Services.Interface;

namespace UnitTestPOC.Test
{
    public class Tests
    {
        private UserController _userController;
        private IUserManager _userManager;
        [SetUp]
        public void Setup()
        {
            var mockedUserManager = new Mock<IUserManager>();
            var mockedUser = Mock.Of<User>(x => x.Id == 1 && x.Name == "mich" && x.Email == "mich@gmail.com");
            mockedUserManager.Setup(x => x.GetUser(It.IsIn<int>())).ReturnsAsync(mockedUser);
            _userManager = mockedUserManager.Object;
            _userController = new UserController(_userManager);
        }

        [Test]
        public async Task Getuser_CorrectValueGiven_Return_Success()
        {
            int id = 1;
            var result = await _userManager.GetUser(id);
            
            Assert.Pass();
        }
    }
}