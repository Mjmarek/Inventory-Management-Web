using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inventory.Contracts;
using Inventory.Models;
using Inventory.Web.Controllers;
using Telerik.JustMock;

namespace ProductServices.Test
{
    [TestClass]
    public class InventoryControllerTests
    {
        [TestMethod]
        public void Index_Returns_All_Products()
        {
            //Arange
            var product = Mock.Create<IProduct>();

            Mock.Arrange(() => product.GetProducts()).
                Returns(new List<ProductListModel>()
                {
                    new ProductListModel { ProductId=3, Flag=1, Number="ABC-0123", Name="Alphabet Blocks",
                            Quantity=0, Location="0602", Comments="2 in backstock", UserName="Manager1"},
                    new ProductListModel { ProductId=5, Number="ABC-1234", Name="Dictionary",
                            Quantity=1, Location="02BOOKSA", Comments="Check backstock", UserName="Manager1"},
                    new ProductListModel { ProductId=9, Number="EFG-2345", Name="Math Puzzle",
                            Quantity=1, Location="0103", Comments="", UserName="Manager1"}

                }).MustBeCalled();
            Guid newGuid = new Guid();

            //Act
            InventoryController controller = new InventoryController(product);
            ViewResult viewResult = controller.Index();
            var model = viewResult.Model as IEnumerable<ProductListModel>;

            //Assert
            Assert.AreEqual(product, 2);
        }

        [TestMethod()]
        public void QuoteCreateTest()
        {
            //Arrange
            InventoryController inventoryController = new InventoryController();

            //Act
            ActionResult result = inventoryController.Create() as ActionResult;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void QuoteIndexTest()
        {
            //Arrange
            InventoryController inventoryController = new InventoryController();

            //Act
            ActionResult result = inventoryController.Create() as ActionResult;

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
