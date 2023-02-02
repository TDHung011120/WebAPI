using System;
using System.Collections.Generic;
using Web.Data.Infrastructure;
using Web.Model.Models;

namespace Web.Service
{
    public interface IPostCategoryService
    {
        void Add(PostCategory postCategory);

        void Update(PostCategory postCategory);

        void Delete(int id);

        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GetAllByParentID(int parentId);

        PostCategory GetById(int id);
        void SaveChange(); 
    }

    public class PostCategoryService : IPostCategoryService
    {
        private IPostCategoryService _postCategoryService;
        private IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryService postCategoryService, IUnitOfWork unitOfWork)
        {
            this._postCategoryService = postCategoryService;
            this._unitOfWork = unitOfWork;
        }

        public void Add(PostCategory postCategory)
        {
            _postCategoryService.Add(postCategory);
        }

        public void Delete(int id)
        {
            _postCategoryService.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
            return _postCategoryService.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentID(int parentId)
        {
            return _postCategoryService.GetAllByParentID(parentId); 
        }

        public PostCategory GetById(int id)
        {
            return _postCategoryService.GetById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryService.Update(postCategory);
        }
    }
}