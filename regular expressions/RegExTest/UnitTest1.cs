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
            Assert.IsTrue(Validator.ValidName("Valid Name"));
            Assert.IsTrue(Validator.ValidName("Longer Valid Name"));
        }

        [TestMethod]
        public void InvalidNameWithNumbers()
        {
            Assert.IsFalse(Validator.ValidName("123 Joe"));
            Assert.IsFalse(Validator.ValidName("H4xor G0d"));
        }

        [TestMethod]
        public void InvalidNamesNotCapital()
        {
            Assert.IsFalse(Validator.ValidName("little Letter"));
            Assert.IsFalse(Validator.ValidName("Little letter"));
        }

        [TestMethod]
        public void InvalidNameEmptyString()
        {
            Assert.IsFalse(Validator.ValidName(""));
        }

        [TestMethod]
        public void ValidPhoneNumber()
        {
            Assert.IsTrue(Validator.ValidCellPhoneNumberHUN("+36 20 123 3456"));
            Assert.IsTrue(Validator.ValidCellPhoneNumberHUN("+36 30 321 3445"));
        }

        public void InvalidPhoneNumberFormat()
        {
            Assert.IsFalse(Validator.ValidCellPhoneNumberHUN("+36201233456"));
            Assert.IsFalse(Validator.ValidCellPhoneNumberHUN("36 30 123 2345"));
            Assert.IsFalse(Validator.ValidCellPhoneNumberHUN("+36 54 123 1234"));
        }

        public void InvalidPhoneNumberNotNumber()
        {
            Assert.IsFalse(Validator.ValidCellPhoneNumberHUN("+36 30 123 234o"));
            Assert.IsFalse(Validator.ValidCellPhoneNumberHUN("+36 30 ## ?:! 241O"));
        }

        public void InvalidPhoneNumberEmptyString()
        {
            Assert.IsFalse(Validator.ValidCellPhoneNumberHUN(""));
        }

        [TestMethod]
        public void ValidEmailAddress()
        {
            Assert.IsTrue(Validator.ValidateEmail("something@otherthing.com"));
        }

        [TestMethod]
        public void InvalidEmailNoAtSign()
        {
            Assert.IsFalse(Validator.ValidateEmail("missingatsign.com"));
        }

        [TestMethod]
        public void InvalidEmailMultipleAtSign()
        {
            Assert.IsFalse(Validator.ValidateEmail("toomany@@atsign.com"));
            Assert.IsFalse(Validator.ValidateEmail("toom@ny@atsign.com"));
        }

        [TestMethod]
        public void InvalidEmailNoDot()
        {
            Assert.IsFalse(Validator.ValidateEmail("there@isnodothere"));
        }

        [TestMethod]
        public void InvalidEmailTooManyDots()
        {
            Assert.IsFalse(Validator.ValidateEmail("there@retoo.many..dots"));
            Assert.IsFalse(Validator.ValidateEmail("dots..every@where.here"));
        }

        [TestMethod]
        public void InvalidEmailAddressCapital()
        {
            Assert.IsFalse(Validator.ValidateEmail("BIGLETTERS@notgood.ro"));
            Assert.IsFalse(Validator.ValidateEmail("noteven@HERE.hu"));
            Assert.IsFalse(Validator.ValidateEmail("nor@there.COM"));
        }

        [TestMethod]
        public void InvalidEmailEmptyStrnig()
        {
            Assert.IsFalse(Validator.ValidateEmail(""));
        }
    }
}
