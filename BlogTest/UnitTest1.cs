using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BlogLib;

namespace BlogTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BlogInfoTest()
        {
            
            var blogid = new BlogInfo { BlogId = 1 };
            var blogTitle = new BlogInfo { Title = "Test" };
            
            var blogIdTest = blogid.BlogId;
            var blogTitleTest = blogTitle.Title;
            
            Assert.AreEqual(1, blogIdTest);
            Assert.AreEqual("Test", blogTitleTest);
        }

        [TestMethod]
        public void EmpInfoTest()
        {
            var empid = new EmpInfo { EmpId = 1 };
            var empName = new EmpInfo { Name = "Name" };

            var empIdTest = empid.EmpId;
            var empNameTest = empName.Name;

            Assert.AreEqual(1, empIdTest);
            Assert.AreEqual("Name", empNameTest);
        }
    }
}
