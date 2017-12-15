using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Tests
{
    [TestClass]
    public class InventoryControllerTests
    {
        [TestMethod]
        public void Index_Returns_All_Products_In_DB()
        {
            var product = Mock.Create<IProduct>();

            Mock.Arrange(() => product.GetProducts()).
                Returns(new List<ProductListModel>()
                {
                    new ProductListModel {}
                }
        }
    }
}
