using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Model;

namespace TeduShop.Service
{
    public interface IPostCategoryService
    {
        PostCategory  Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        PostCategory Delete(int id);
        IEnumerable<PostCategory> GetAll();
        PostCategory GetById(int id);
        IEnumerable<PostCategory> GetAllByParentId(int parentId); 
    }
    public class PostCategoryService : IPostCategoryService
    {
        IPostCategoryRepository _postCategoryRepository;
        IUnitOfWork _unitOfWork;

        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }
        public PostCategory Add(PostCategory postCategory)
        {

           return _postCategoryRepository.Add(postCategory);
        }

        public PostCategory Delete(int id)
        {
           return _postCategoryRepository.Delete(id);
        }

        public IEnumerable<PostCategory> GetAll()
        {
           return _postCategoryRepository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentId(int parentId)
        {
          return   _postCategoryRepository.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public PostCategory GetById(int id)
        {
            return _postCategoryRepository.GetSingleById(id);
        }

        public void Update(PostCategory postCategory)
        {
            _postCategoryRepository.Update(postCategory);
        }
    }
}
