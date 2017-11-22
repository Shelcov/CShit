using IService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface ITagService
    {
        /// <summary>
        /// получить список тэгов
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        List<TagModel> GetTagList();

        /// <summary>
        /// получить конкретный тэг
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TagModel GetTag(int id);

        /// <summary>
        /// редактирвоать тэг
        /// </summary>
        /// <param name="oldTag"></param>
        /// <returns></returns>
        BaseResponce EditTag(TagModel oldTag);

        /// <summary>
        /// добавить новый тэг
        /// </summary>
        /// <param name="newTag"></param>
        /// <returns></returns>
        BaseResponce AddTag(TagModel newTag);

        /// <summary>
        /// удалить тэг
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        BaseResponce DeleteTag(int id);
    }
}
