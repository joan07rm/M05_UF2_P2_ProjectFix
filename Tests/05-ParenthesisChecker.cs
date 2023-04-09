using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text;

namespace Tests
{
    [TestClass]
    public class ParenthesisChecker_Tests
    {
        [TestMethod]
        public void ParenthesisChecker_Test()
        {
            //Arrange
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Utils.random.Next(10,100); i++)
            {
                if(Utils.random.Next(2) > 0)
                {
                    sb.Append('(');
                }
                else
                {
                    sb.Append(')');
                }
            }
            string original = sb.ToString();
            bool resultOK = false;
            if (original[0] == '(' && original.Length % 2 == 0)
            {
                int countOpen = original.Count(c => c == '(');
                int countClose = original.Count(c => c == ')');
                resultOK = countOpen == countClose;
            }
            bool result = false;
            //Act
            result = ParenthesisChecker.Program.CountChars(original, ')') == ParenthesisChecker.Program.CountChars(original, '(');
            //Assert
            Assert.AreEqual(resultOK, result);
        }
    }
}
