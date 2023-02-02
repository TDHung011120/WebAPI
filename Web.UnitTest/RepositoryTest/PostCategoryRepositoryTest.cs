using Microsoft.VisualStudio.TestTools.UnitTesting;
using Web.Data.Infrastructure;
using Web.Data.Repositories;
using Web.Model.Models;

namespace Web.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        private DbFactory DbFactory;
        private IPostCategoryRepository objRepository;
        private IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            DbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(DbFactory);
            unitOfWork = new UnitOfWork(DbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory postCategory = new PostCategory();

            postCategory.Name = "Test_Category";
            postCategory.Alias = "Test-Category";
            postCategory.ParentID = 1;
            postCategory.HomeFlag = true;
            postCategory.Status = true;

            var result = objRepository.Add(postCategory);
            unitOfWork.Commit();
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}