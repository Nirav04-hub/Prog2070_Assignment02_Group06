using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment02_Grp_06
{
    [TestFixture]
    public class ProductTests

    // The first 6 tests are written by Nirav Saxena
    //    The tests focus on confirming correct data storage and retrieval of product ID together with item price.
    //  These tests have been selected to verify that product identifiers together with their prices keep accurate records both at initialization and throughout maintenance cycles.
    {
        [Test]
        public void ProdId_Input8_Output8()
        {
            // Test case 1: ProdId should accept the minimum valid value

            // Arrange
            Product product1 = new Product(8, "Product1", 1000, 50);

            // Act
            int expected = 8;

            // Assert
            Assert.That(expected, Is.EqualTo(product1.ProdId));

        }

        [Test]
        public void ProdId_Input80000_Output80000()
        {
            // Test case 2: ProdId should accept maximum valid value
            // Arrange
            Product product2 = new Product(80000, "Product2", 1000, 50);

            // Act
            int expected = 80000;

            // Assert
            Assert.That(expected, Is.EqualTo(product2.ProdId));
        }

        [Test]
        public void ProdId_Input40000_Output40000()
        {
            // Test case 3: ProdId should be in the range between 8 to 80000

            // Arrange
            Product product3 = new Product(40000, "Product3", 1000, 50);

            // Act
            int expected = 40000;

            // Assert
            Assert.That(expected, Is.EqualTo(product3.ProdId));
        }

        [Test]
        public void ItemPrice_Input8_Output8()
        {
            // Test case 4: ItemPrice should be minimum valid

            // Arrange
            Product product4 = new Product(100, "Product4", 8, 50);

            // Act
            int expected = 8;

            // Assert
            Assert.That(expected, Is.EqualTo(product4.ItemPrice));
        }

        [Test]
        public void ItemPrice_Input8000_Output8000()
        {
            // Test case 5: ItemPrice should accept maximum valid value
            // Arrange
            Product product5 = new Product(100, "Product5", 8000, 50);

            // Act
            int expected = 8000;

            // Assert
            Assert.That(expected, Is.EqualTo(product5.ItemPrice));
        }

        [Test]
        public void ItemPrice_Input4000_Output4000()
        {
            //Test case 6: ItemPrice should be in the range of 8 to 8000
            // Arrange
            Product product6 = new Product(100, "Product6", 4000, 50);

            // Act
            int expected = 4000;

            // Assert
            Assert.That(expected, Is.EqualTo(product6.ItemPrice));
        }
        
    }
}
