using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class Factorial_Tests
    {
        [TestMethod]
        public void Average_Test()
        {
            //Arrange
            List<float> numbers = new List<float>();
            for (int i = 0; i < Utils.random.Next() % 100; i++)
            {
                numbers.Add(Utils.random.Next() % 100);
            }
            float result = 0;
            float resultOK = numbers.Average();
            //Act
            result = Factorial.Program.average(numbers);
            //Assert
            Assert.AreEqual(resultOK, result);
        }
        [TestMethod]
        public void For_Test()
        {
            //Arrange
            ulong fac = (ulong)Utils.random.Next() % 20;
            ulong result = 0;
            ulong resultOK = Utils.FactorialOK(fac);
            //Act
            result = Factorial.Program.factorial_for(fac);
            //Assert
            Assert.AreEqual(resultOK, result);
        }
        [TestMethod]
        public void Recursive_Test()
        {
            //Arrange
            ulong fac = (ulong)Utils.random.Next() % 20;
            ulong result = 0;
            ulong resultOK = Utils.FactorialOK(fac);
            //Act
            result = Factorial.Program.factorial_recursive(fac);
            //Assert
            Assert.AreEqual(resultOK, result);
        }
    }
}
