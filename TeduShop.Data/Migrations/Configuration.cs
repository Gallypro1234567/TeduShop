namespace TeduShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TeduShop.Model.Model;
    using TeduShop.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TeduShop.Data.TedushopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeduShop.Data.TedushopDbContext context)
        {
            CreatProductCategorySample(context);
             //  This method will be called after migrating to the latest version.
             var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TedushopDbContext()));
             var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TedushopDbContext()));
             //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
             //  to avoid creating duplicate seed data.
             var user = new ApplicationUser()
             {
                 UserName = "tedu",
                 Email = "Tefu.international@gmail.com",
                 EmailConfirmed = true,
                 BirthDay = DateTime.Now,              
                 FullName = "Technology Education"
             };
             manager.Create(user, "123654$");
             if (!roleManager.Roles.Any())
             {
                 roleManager.Create(new IdentityRole { Name = "Admin" });
                 roleManager.Create(new IdentityRole { Name = "User" });
             }
             var adminUser = manager.FindByEmail("Tefu.international@gmail.com");
             manager.AddToRoles(adminUser.Id, new string[] { "admin", "User" });
        }
        private void CreatProductCategorySample(TeduShop.Data.TedushopDbContext context)
        {
            if (context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
            {
                new ProductCategory(){ Name=" Điện lạnh", Alias="dien-lanh",Status=true},
            new ProductCategory() { Name = " Viễn Thông", Alias = "vien-thong", Status = true },
            new ProductCategory() { Name = "Đồ gia dụng", Alias = "do-gia-dung", Status = true },
            new ProductCategory() { Name = "mỹ phẩm", Alias = "my-pham", Status = true },
            };
                context.ProductCategories.AddRange(listProductCategory);
                context.SaveChanges();
            }
        }
    }
}
