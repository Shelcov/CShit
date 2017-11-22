using IService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface IPostService
    {
        /// <summary>
        /// получить список постов
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        List<PostModel> GetPostList(TagModel tag);

        /// <summary>
        /// получить конкретный пост
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        PostModel GetPost(int id);

        /// <summary>
        /// редактирвоать пост
        /// </summary>
        /// <param name="oldPost"></param>
        /// <returns></returns>
        BaseResponce EditPost(PostModel oldPost);

        /// <summary>
        /// добавить новый пост
        /// </summary>
        /// <param name="newPost"></param>
        /// <returns></returns>
        BaseResponce AddPost(PostModel newPost);

        /// <summary>
        /// удалить пост
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BaseResponce DeletePost(int id);
    }
}
