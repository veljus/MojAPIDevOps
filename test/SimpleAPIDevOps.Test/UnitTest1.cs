using System;
using Xunit;
using SimpleAPIDevOps.Controllers;

namespace SimpleAPIDevOps.Test
{
    public class UnitTest1
    {
        HomesController homesController = new HomesController();
        [Fact]
        public void GetReturnsName()
        {
            var returnValue = homesController.Get(0);
            Assert.Equal(returnValue,"world");
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
