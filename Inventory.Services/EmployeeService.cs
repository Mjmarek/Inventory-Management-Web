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
    public class EmployeeService : IEmployee
    {
        public bool CreateEmployee(EmployeeCreateModel model)
        {
            var entity =
                new EmployeeEntity
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    UserName = model.UserName,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Employees.Add(entity);

                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<EmployeeListModel> GetEmployeeList()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Employees.Select
                    (e => new EmployeeListModel
                        {
                            EmployeeId = e.EmployeeId,
                            FirstName = e.FirstName,
                            LastName = e.LastName,
                            UserName = e.UserName,
                            Password = e.Password
                        }
                    );
                return query.ToArray();
            }
        }

        public EmployeeDetailsModel GetEmployeeById (int EmployeeId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Employees.Single(e => e.EmployeeId == EmployeeId);
                return
                    new EmployeeDetailsModel
                    {
                        EmployeeId = entity.EmployeeId,
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        UserName = entity.UserName,
                        Password = entity.Password
                    };
            }
        }

        public bool EditEmployee(EmployeeEditModel model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Employees.Single(e => e.EmployeeId == model.EmployeeId);

                entity.EmployeeId = model.EmployeeId;
                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.UserName = model.UserName;
                entity.Password = model.Password;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteEmployee(int EmployeeId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Employees.Single(e => e.EmployeeId == EmployeeId);

                ctx.Employees.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
