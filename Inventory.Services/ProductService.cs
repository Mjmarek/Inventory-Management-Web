using Inventory.Contracts;
using Inventory.Data;
using Inventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Services
{
    public class ProductService : IProduct
    {
        private readonly Guid _userId;

        public ProductService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateProduct(ProductCreateModel model)
        {
            var entity =
                new Product
                {
                    Flag = model.Flag,
                    Number = model.Number,
                    Name = model.Name,
                    Quantity = model.Quantity,
                    Location = model.Location,
                    Comments = model.Comments
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Products.Add(entity);

                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ProductListModel> GetProductList()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Products.Select
                    (e => new ProductListModel
                        {
                            ProductId = e.ProductId,
                            Flag = e.Flag,
                            Number = e.Number,
                            Name = e.Name,
                            Quantity = e.Quantity,
                            Location = e.Location,
                            Comments = e.Comments,
                            UserName = e.UserName
                        }
                    );
                return query.ToArray();
            }
        }

        public ProductDetailsModel GetProductById (int ProductId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Products.Single
                        (e => e.ProductId == ProductId);

                return
                    new ProductDetailsModel
                    {
                        ProductId = entity.ProductId,
                        Flag = entity.Flag,
                        Number = entity.Number,
                        Name = entity.Name,
                        Quantity = entity.Quantity,
                        Location = entity.Location,
                        Comments = entity.Comments,
                        UserName = entity.UserName
                    };
            }
        }

        public bool EditProduct(ProductEditModel model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Products.Single
                        (e => e.ProductId == model.ProductId);

                entity.ProductId = model.ProductId;
                entity.Flag = model.Flag;
                entity.Number = model.Number;
                entity.Name = model.Name;
                entity.Quantity = model.Quantity;
                entity.Location = model.Location;
                entity.Comments = model.Comments;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteProduct(int ProductId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Products.Single
                        (e => e.ProductId == ProductId);

                ctx.Products.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
