using CKK.Logic.Models;
using Xunit;
using Xunit.Sdk;

namespace CKK.TestsForStudents
{
    public class ProductTests
    {
        [Fact]
        public void GetSetId_ShouldSetAndReturnCorrectId()
        {
            try
            {
                //Assemble
                Product product = new Product(234, "bbb", 9.2M);
                int expected = 54321;
                //Act
                product.SetId(expected);
                int actual = product.GetId();
                //Assert
                Assert.Equal(expected, actual);
            }catch
            {
                throw new XunitException("There was an error that occurred");
                //Assert.False(true, "There was an error that occurred");
            }
        }

        [Fact]
        public void GetSetName_ShouldSetAndReturnCorrectName()
        {
            try
            {
                //Assemble
                Product product = new Product(234, "bbb", 9.2M);
                var expected = "David Everton";

                //Act
                product.SetName(expected);
                var actual = product.GetName();

                //Assert
                Assert.Equal(expected, actual);
            }
            catch
            {
                throw new XunitException("There was an error that occurred");
                //Assert.False(true, "There was an error that occurred");
            }
        }

        [Fact]
        public void GetSetAddress_ShouldSetAndReturnCorrectPrice()
        {
            try
            {
                //Assemble
                Product product = new Product(234, "bbb", 9.2M);
                var expected = 4321.56754m;

                //Act
                product.SetPrice(expected);
                var actual = product.GetPrice();

                //Assert
                Assert.Equal(expected, actual);
            }
            catch
            {
                throw new XunitException("There was an error that occurred");
                //Assert.False(true, "There was an error that occurred");
            }
        }
    }
}
