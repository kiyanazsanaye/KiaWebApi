using KiaWebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTest
{
    public class UnitTest
    {
        private readonly ILogger<ActronAirController> _logger;
        private readonly List<int> lst = new List<int>() { 10, 223, 78, 90, 99 };


        [Fact]
        public void TestActronAir()
        {
            var controller = new ActronAirController(_logger);

            // Act
            var result = controller.Get(lst);

            // Assert
            Assert.Equal("99907822310", result);
        }
    }
}
