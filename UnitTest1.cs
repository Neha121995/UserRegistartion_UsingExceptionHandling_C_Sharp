using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace User_TestCase
{
    [TestClass]
    public class UnitTest1
    {
        readonly Pattern pattern = new Pattern();

        [TestMethod]
        public void ShouldReturnCustomUserExceptionForPassword()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, pattern.validatePassword(null));
            }
            catch (RegisterUser e)
            {
                Assert.AreEqual("Invalid Password", e.Message);
            }
        }
    }
}
