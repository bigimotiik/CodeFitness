using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFitness.BL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFitness.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        [TestMethod()]
        public void SetNewUserDataTest()
        {
            var userName = Guid.NewGuid().ToString();
            var birthdate = DateTime.Now.AddYears(-18);
            var weight = 90;
            var height = 180;
            var gender = "man";
            var controller = new UserController(userName);
            controller.SetNewUserData(gender, birthdate, weight, height);
            var conroller2 = new UserController(userName);

            Assert.AreEqual(userName, conroller2.CurrentUser.Name); 
        }

        [TestMethod()]
        public void SaveTest()
        {
            //Arrange
            var userName = Guid.NewGuid().ToString();

            //Act
            var controller = new UserController(userName);

            //Assert
            Assert.AreEqual(userName, controller.CurrentUser.Name);

        }
    }
}