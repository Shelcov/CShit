using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Tag
    {
        /// <summary>
        /// id тэга
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// имя тэга
        /// </summary>
        [DisplayName("Тэг")]
        public string Name { get; set; }
        /// <summary>
        /// имя для адресной строки
        /// </summary>
        public string UrlName { get; set; }
        /// <summary>
        /// список постов с данной ктаегорией
        /// </summary>
        public virtual List<Post> Posts { get; set; }
        public Tag()
        {
            Posts = new List<Post>();
        }
    }
}
