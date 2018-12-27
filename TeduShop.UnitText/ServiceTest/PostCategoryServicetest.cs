using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Model;
using TeduShop.Service;

namespace TeduShop.UnitText
{
    
    [TestClass]
    class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _CategoryService;
        private List<PostCategory> _ListCategory;

        [TestInitialize]
        public void Intitial()
        {
            _mockRepository = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _CategoryService = new PostCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            _ListCategory = new List<PostCategory>()
            {
                new PostCategory() {ID = 1, Name = "DM1", Status = true },
                new PostCategory() {ID = 2, Name = "DM2", Status = true },
                new PostCategory() {ID = 3, Name = "DM3", Status = true },


            };
        }
        [TestMethod]
        public void  PostCategory_service_GetAll()
        {
            // setup method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_ListCategory);
            // call action
            var result = _CategoryService.GetAll() as List<PostCategory>;
            // compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);

        }
        [TestMethod]
        public void PostCategory_service_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test";
            category.Alias = "Test";
            category.Status = true;
            _mockRepository.Setup(m => m.Add(category)).Returns((PostCategory p) =>
              {
                  p.ID = 1;
                  return p;
              });

            var result = _CategoryService.Add(category);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}
