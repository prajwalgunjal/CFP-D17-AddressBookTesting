using ExceptionHandlingAddresssBook;

namespace AddressBookTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private Program program;

        [TestInitialize]
        public void Setup()
        {
            program = new Program();    
        }
        [TestMethod]
        [DataRow("Prajwal", true)]
        [DataRow("prajkta", false)]
        public void CheckFirstName_SHouldReturn_True_IfValid(string name, bool expected)
        {
            bool result = program.TestFirstName(name);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow("prajwal23@gmail.com", true)]
        [DataRow("prajwal23@.com", false)]
        public void CHeckEmail_ShouldReturnTrue_IfValid(string email, bool expected)
        {
            bool result = program.TestEmail(email);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        [DataRow("+91 9881640062", true)]
        [DataRow("9881640062", false)]

        public void CHeckPhoneNumber_ShouldReturnTrue_IfValid(string number, bool expected)
        {
            bool result = program.TestPhoneNumber(number);
            Assert.AreEqual(expected, result);
        }


    }
}