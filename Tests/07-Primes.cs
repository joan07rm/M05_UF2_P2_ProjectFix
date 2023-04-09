using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class Primes_Tests
    {
        [TestMethod]
        public void IsPrime_Test()
        {
            //Arrange
            int original = Utils.random.Next();
            bool result = false;
            bool resultOK = Utils.IsPrimeOK(original);
            //Act
            result = Primes.Program.IsPrime(original);
            //Assert
            Assert.AreEqual(resultOK, result);
        }
    }
}
