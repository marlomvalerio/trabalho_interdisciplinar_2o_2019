using trabalho_interdisciplinar_388614.api.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace trabalho_interdisciplinar_388614.api.tests.Controllers
{
    public class PresentationApiControllerTest
    {
        private PresentationApiController _context;



        public PresentationApiControllerTest()
        {
            _context = new PresentationApiController();
        }


        [Fact]
        public void Teste()
        {
            var expected = new OkObjectResult("Teste");

            var actual = (OkObjectResult)_context.CalculateMinimumWaterRoutesBusiness();

            Assert.Equal(expected.Value, actual.Value);
            Assert.Equal(expected.StatusCode, actual.StatusCode);
        }
    }
}
