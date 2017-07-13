using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApiTests.Helpers;
using ApiTests.Models;
using System.Collections.Generic;
using RestSharp;
using System.Net;

namespace ApiTests.Test
{
    [TestClass]
    public class GetPostsTests
    {
        [TestMethod]
        public void GetAllPostsShouldReturnListOfPosts()
        {
            var response = ApiFactory.GetMethod<List<PostModel>>("/posts");

            Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);

            foreach(PostModel post in response.Data)
            {
                Assert.IsNotNull(post);
            }
        }
    }
}
