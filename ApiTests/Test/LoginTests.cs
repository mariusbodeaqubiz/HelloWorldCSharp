using ApiTests.Helpers;
using ApiTests.Models;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiTests.Test
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void LogInSuccessfully()
        {
            var loginData = new UserModel() { username = "testaccount", password = "password123" };

            var response = ApiFactory.PostMethod<UserModel>("/login", loginData);

            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
        }

        [TestMethod]
        public void LogInWithIncorrectPassword()
        {
            var loginData = new UserModel() { username = "testaccount", password = "password1234" };

            var response = ApiFactory.PostMethod<UserModel>("/login", loginData);

            Assert.AreNotEqual(response.StatusCode, HttpStatusCode.OK);
        }
    }
}
