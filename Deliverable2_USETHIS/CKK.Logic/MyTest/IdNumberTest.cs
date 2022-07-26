using Microsoft.VisualStudio.TestTools.UnitTesting;
using CKK.Logic.Models;
using CKK.Logic.Exceptions;


namespace MyTest
{
    [TestClass]
    public class IdNumberTest
    {
        [TestMethod]
        public void IdNumber_MustBeAPositiveNumber()
        {
            try
            {
                //Assemble
                Customer customer = new Customer();
                int expected = 54321;

                //Act
                int actual = customer.Id;

                //Assert
                Assert.Equals(expected, actual);
            }
            catch
            {
                throw new InvalidIdException();
            }
        }
    }
}
