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
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);
        Post GetById(int id);
        IEnumerable<Post> GetAllByTagPaging(string tag,int page, int pageSize, out int totalRow);
        void SaveChangse();
    }
    public class PostService : IPostService 
    {
        // cach can chus ys xem ki bai 8
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;
        public PostService (IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }
        // ////////////////////////////////
        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            // cái hay của entity này là có thể lấy cả danh mục của thằng khác
            return  _postRepository.GetAll( new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            // todo get all post by tag
            return  _postRepository.GetMultiPaging( x => x.Status , out totalRow, page, pageSize);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChangse()
        {
              _unitOfWork.Commit();
           
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}
