using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IService.Models;
using DAL;
using DAL.Models;

namespace Service
{
    public class PostService : IPostService
    {
        public BaseResponce AddPost(PostModel newPost)
        {
            throw new NotImplementedException();
        }

        public BaseResponce DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public BaseResponce EditPost(PostModel oldPost)
        {
            throw new NotImplementedException();
        }

        public PostModel GetPost(int id)
        {
            throw new NotImplementedException();
        }

        public List<PostModel> GetPostList(TagModel tag)
        {
            using (var db = new DataContext())
            {
                return db.Posts
                    .Where(a => a.Tags.Any(x => x.Id == tag.Id))
                    .Select(ConvertToPostModel)
                    .ToList();
            }
        }
        private PostModel ConvertToPostModel(Post v)
        {
            return new PostModel
            {
                Id = v.Id,
                Description = v.Description
                //.....
            };
        }
    }
}
