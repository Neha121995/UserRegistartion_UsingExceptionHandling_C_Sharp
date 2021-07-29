using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace User_TestCase
{
    [TestClass]
    public class UnitTest1
    {
        readonly Pattern pattern = new Pattern();

        [TestMethod]
        public void ShouldReturnCustomUserExceptionForMobileNumber()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, pattern.validateMobileNumber(null));
            }
            catch (RegisterUser e)
            {
                Assert.AreEqual("Invalid Mobile Number", e.Message);
            }
        }
    }
}
