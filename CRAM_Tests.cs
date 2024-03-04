using CRAM;

namespace CRAM_Tests
{
    [TestClass]
    public class CRAM_Tests
    {
        [TestMethod]
        public void ValidationOK()
        {
            int option = 1;
            Assert.IsFalse(Program.Validation(option));
        }

        [TestMethod]
        public void ValidationError()
        {
            int option = 3;
            Assert.IsTrue(Program.Validation(option));
        }

        [TestMethod]
        public void RandomStringsOK()
        {
            string[] values = {"abc","def"};
            string result = Program.RandomStrings(values);
            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void RandomNumsOK()
        {
            int result = Program.RandomValues(0,10);
            Assert.IsInstanceOfType(result, typeof(int));
        }
    }
}