using Microsoft.VisualStudio.TestTools.UnitTesting;
using regular_expressions;


namespace RegExTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ValidNameGoodParams()
        {
            Assert.IsTrue(RegexOperations.ValidName("Valid Name"));
            Assert.IsTrue(RegexOperations.ValidName("Longer Valid Name"));
        }

        [TestMethod]
        public void InvalidNameWithNumbers()
        {
            Assert.IsFalse(RegexOperations.ValidName("123 Joe"));
            Assert.IsFalse(RegexOperations.ValidName("H4xor G0d"));
        }

        [TestMethod]
        public void InvalidNamesNotCapital()
        {
            Assert.IsFalse(RegexOperations.ValidName("little Letter"));
            Assert.IsFalse(RegexOperations.ValidName("Little letter"));
        }

        [TestMethod]
        public void InvalidNameEmptyString()
        {
            Assert.IsFalse(RegexOperations.ValidName(""));
        }

        [TestMethod]
        public void ValidPhoneNumber()
        {
            Assert.IsTrue(RegexOperations.ValidCellPhoneNumberHUN("+36 201233456"));
            Assert.IsTrue(RegexOperations.ValidCellPhoneNumberHUN("+36 303213445"));
        }

        public void InvalidPhoneNumberFormat()
        {
            Assert.IsFalse(RegexOperations.ValidCellPhoneNumberHUN("+36201233456"));
            Assert.IsFalse(RegexOperations.ValidCellPhoneNumberHUN("36 30 123 2345"));
            Assert.IsFalse(RegexOperations.ValidCellPhoneNumberHUN("+36 54 1231234"));
        }

        public void InvalidPhoneNumberNotNumber()
        {
            Assert.IsFalse(RegexOperations.ValidCellPhoneNumberHUN("+36 30123234o"));
            Assert.IsFalse(RegexOperations.ValidCellPhoneNumberHUN("+36 30##?:!241O"));
        }

        public void InvalidPhoneNumberEmptyString()
        {
            Assert.IsFalse(RegexOperations.ValidCellPhoneNumberHUN(""));
        }

        [TestMethod]
        public void ValidEmailAddress()
        {
            Assert.IsTrue(RegexOperations.ValidateEmail("something@otherthing.com"));
        }

        [TestMethod]
        public void InvalidEmailNoAtSign()
        {
            Assert.IsFalse(RegexOperations.ValidateEmail("missingatsign.com"));
        }

        [TestMethod]
        public void InvalidEmailMultipleAtSign()
        {
            Assert.IsFalse(RegexOperations.ValidateEmail("toomany@@atsign.com"));
            Assert.IsFalse(RegexOperations.ValidateEmail("toom@ny@atsign.com"));
        }

        [TestMethod]
        public void InvalidEmailNoDot()
        {
            Assert.IsFalse(RegexOperations.ValidateEmail("there@isnodothere"));
        }

        [TestMethod]
        public void InvalidEmailTooManyDots()
        {
            Assert.IsFalse(RegexOperations.ValidateEmail("there@retoo.many..dots"));
            Assert.IsFalse(RegexOperations.ValidateEmail("dots..every@where.here"));
        }

        [TestMethod]
        public void InvalidEmailAddressCapital()
        {
            Assert.IsFalse(RegexOperations.ValidateEmail("BIGLETTERS@notgood.ro"));
            Assert.IsFalse(RegexOperations.ValidateEmail("noteven@HERE.hu"));
            Assert.IsFalse(RegexOperations.ValidateEmail("nor@there.COM"));
        }

        [TestMethod]
        public void InvalidEmailEmptyStrnig()
        {
            Assert.IsFalse(RegexOperations.ValidateEmail(""));
        }
    }
}
