using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApiTests.Models;
using ApiTests.Helpers;
using System.Net;
using System.Collections.Generic;

namespace ApiTests.Test
{
    [TestClass]
    public class PostsTests
    {
        [TestMethod]
        public void AddANewPost()
        {
            // Login
            var loginData = new UserModel() { username = "testaccount", password = "password123" };

            var loginResponse = ApiFactory.PostMethod<UserModel>("/login", loginData);

            Assert.AreEqual(loginResponse.StatusCode, HttpStatusCode.OK);


            // Add new post
            var postData = new PostModel() { author = 2, title = "C# test", text = "This is from a C# project" };

            var postResponse = ApiFactory.PostMethod<PostModel>("/post/new/", postData);

            Assert.AreEqual(postResponse.StatusCode, HttpStatusCode.OK);

        }
    }
}
