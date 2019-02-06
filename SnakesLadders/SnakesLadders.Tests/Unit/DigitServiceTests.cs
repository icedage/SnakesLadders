using NUnit.Framework;
using SnakesLadders.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakesLadders.Tests.Unit
{
   [TestFixture]
   public class DigitServiceTests
   {
        private IDigitService _digitService;

        [SetUp]
        public void Init()
        {
            _digitService = new DigitService();
        }

        [Test]
        public void GetDigit_Should_Return_Number_Within_1_To_6_Range()
        {
            var number = _digitService.GetDigit();
            Assert.LessOrEqual(number, 6);
        }
    }
}
