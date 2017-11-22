using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IService.Models;
using DAL;
using System.Data.Entity;
using DAL.Models;

namespace Service
{
    public class TagService : ITagService
    {
        public BaseResponce AddTag(TagModel newTag)
        {
            using (var db = new DataContext())
            {
                var answer = new BaseResponce() { Success = true, Message = "Ok" };
                var tag = new Tag
                {                   
                    Name = newTag.Name,
                    UrlName = newTag.UrlName
                };
                db.Tags.Add(tag);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    answer.Success = false;
                    answer.Message = "Ti mudlo";
                }
                return answer;
            }
        }
        public BaseResponce DeleteTag(int id)
        {
            using (var db = new DataContext())
            {
                var answer = new BaseResponce() { Success = true, Message = "Ok" };
                var category = db.Tags.First(_ => _.Id == id);
                db.Entry(category).State = EntityState.Deleted;
                try
                {
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    answer.Success = false;
                    answer.Message = "Ti mudlo";
                }
                return answer;
            }
        }

        public BaseResponce EditTag(TagModel oldTag)
        {
            throw new NotImplementedException();
        }

        public TagModel GetTag(int id)
        {
            throw new NotImplementedException();
        }

        public List<TagModel> GetTagList()
        {
            using (var db = new DataContext())
            {
                return db.Tags
                    .Select(ConvertToTagModel)
                    .ToList();
            }
        }
        private TagModel ConvertToTagModel(Tag v)
        {
            return new TagModel
            {
                Name = v.Name,
                UrlName = v.UrlName,
                Id = v.Id
            };
        }
    }
}
