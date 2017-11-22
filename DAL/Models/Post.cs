using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Post
    {
        /// <summary>
        /// id поста
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// заголовок поста
        /// </summary>
        [DisplayName("Заголовок")]
        public string Title { get; set; }
        /// <summary>
        /// заголовок для адресной строки
        /// </summary>
        public string UrlTitle { get; set; }
        /// <summary>
        /// краткое описание поста
        /// </summary>
        public string ShortDescription { get; set; }
        /// <summary>
        /// полный текст поста
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// дата публикации поста
        /// </summary>
        [DisplayName("Опубликовано")]
        public DateTime Published { get; set; }
        /// <summary>
        /// автор публикации поста
        /// </summary>
        [DisplayName("Автор")]
        public string User { get; set; }
        /// <summary>
        /// список тэгов поста
        /// </summary>
        public virtual List<Tag> Tags { get; set; }
    }
}
