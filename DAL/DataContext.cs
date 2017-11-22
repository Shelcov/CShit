using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// посты в блоге
        /// </summary>
        public DbSet<Post> Posts { get; set; }
        /// <summary>
        /// тэги постов
        /// </summary>
        public DbSet<Tag> Tags { get; set; }
    }
}
