using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class PasswordCheckerTests
    {
        [TestMethod()]
        public void Check_8Symbols_ReturnsTrue()
        {
            // arrange
            string password = "ASqw12$$";
            bool expected = true;

            // act
            bool actual = PasswordChecker.ValidatePassword(password);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_4Symbols_ReturnsFalse()
        {
            // arrange
            string password = "Aq1$";
            bool expected = false;

            // act
            bool actual = PasswordChecker.ValidatePassword(password);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_30Symbols_ReturnsFalse()
        {
            // arrange
            string password = "ASDqwe123$ASDqwe123$ASDqwe123$";
            bool expected = false;

            // act
            bool actual = PasswordChecker.ValidatePassword(password);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithDigits_ReturnsTrue()
        {
            // arrange
            string password = "ASDqwe1$";
            bool expected = true;

            // act
            bool actual = PasswordChecker.ValidatePassword(password);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutDigits_ReturnsFalse()
        {
            // arrange
            string password = "ASDqweASD$";
            bool expected = false;

            // act
            bool actual = PasswordChecker.ValidatePassword(password);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithSpecSymbols_ReturnsTrue()
        {
            // arrange
            string password = "Aqwe123$";
            bool expected = true;

            // act
            bool actual = PasswordChecker.ValidatePassword(password);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutSpecSymbols_ReturnsFalse()
        {
            // arrange
            string password = "ASDqwe123";
            bool expected = false;

            // act
            bool actual = PasswordChecker.ValidatePassword(password);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithCapsSymbols_ReturnsTrue()
        {
            // arrange
            string password = "Aqwe123$";
            bool expected = true;

            // act
            bool actual = PasswordChecker.ValidatePassword(password);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutCapsSymbols_ReturnsFalse()
        {
            // arrange
            string password = "asdqwe123$";
            bool expected = false;

            // act
            bool actual = PasswordChecker.ValidatePassword(password);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithLowerSymbols_ReturnsTrue()
        {
            // arrange
            string password = "ASDq123$";
            bool expected = true;

            // act
            bool actual = PasswordChecker.ValidatePassword(password);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Check_PasswordWithoutLowerSymbols_ReturnsFalse()
        {
            // arrange
            string password = "ASDQWE123$";
            bool expected = false;

            // act
            bool actual = PasswordChecker.ValidatePassword(password);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}