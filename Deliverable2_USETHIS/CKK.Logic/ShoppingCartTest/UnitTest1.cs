using System;
using CKK.Logic.Models;
using Xunit;

namespace ShoppingCartTest
{
    public class ShoppingCartTests
    {
        [Fact]
        public void Constructor_CustomerIdReturnSameAsInput()
        {
            //Assemble
            int expectedId = 666;
            Customer testCustomer = new Customer();
            testCustomer.SetId(expectedId);

            ShoppingCart testCart = new ShoppingCart(testCustomer);
            //Act
            int customerId = testCart.GetCustomerId();

            //Assert
            Assert.Equal(customerId, expectedId);

        }

        [Fact]
        public void ShoppingCart_AddProduct()
        {
            //Assemble
            int expectedId = 666;
            int expectedProductId = 1;
            int productQuantity = 3;
            Customer testCustomer = new Customer();
            testCustomer.SetId(expectedId);

            ShoppingCart testCart = new ShoppingCart(testCustomer);
            Product testProduct = new Product();
            testProduct.SetId(expectedProductId);

            //Act
            ShoppingCartItem addedItem = testCart.AddProduct(testProduct, productQuantity);

            //Assert
            Assert.Equal(addedItem.GetId(), expectedProductId);
            Assert.Equal(addedItem.GetQuantity(), productQuantity);

            // Add another 3 products to the cart (duplicates)
            ShoppingCartItem duplicateAddedItem = testCart.AddProduct(testProduct, productQuantity);

            // Assert that the product ID is still the same and that double the amount is provided
            Assert.Equal(duplicateAddedItem.GetId(), expectedProductId);
            Assert.Equal(duplicateAddedItem.GetQuantity(), productQuantity * 2);
        }

        [Fact]
        public void ShoppingCart_RemoveProduct()
        {
            //Assemble
            int expectedId = 666;
            int expectedProductId = 1;
            int productQuantity = 3;
            int expectedRemaining = 2;
            int firstRemove = 1;
            int secondRemove = 2;
            Customer testCustomer = new Customer();
            testCustomer.SetId(expectedId);

            ShoppingCart testCart = new ShoppingCart(testCustomer);
            Product testProduct = new Product();
            testProduct.SetId(expectedProductId);

            //Act
            testCart.AddProduct(testProduct, productQuantity);
            ShoppingCartItem remainingItems = testCart.RemoveProduct(testProduct, firstRemove);
            Assert.Equal(remainingItems.GetQuantity(), expectedRemaining);

            ShoppingCartItem emptyItem = testCart.RemoveProduct(testProduct, secondRemove);
            Assert.Null(emptyItem);
        }

        [Fact]
        public void ShoppingCart_GetTotal()
        {
            //Assemble
            int expectedId = 666;
            int expectedProductId = 1;
            int productQuantity = 3;
            int expectedTotal = 3;
            Customer testCustomer = new Customer();
            testCustomer.SetId(expectedId);

            ShoppingCart testCart = new ShoppingCart(testCustomer);
            Product testProduct = new Product();
            testProduct.SetPrice(1);
            testProduct.SetId(expectedProductId);

            //Act
            // Add 3 products to the cart
            testCart.AddProduct(testProduct, productQuantity);

            //Assert
            // Assert that the cart's total matches the quantity of the product multiplied by the price
            Assert.Equal(testCart.GetTotal(), expectedTotal);
        }
    }
}
