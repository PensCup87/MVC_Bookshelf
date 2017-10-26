using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Bookshelf.Models
{
    public class MVC_BookshelfContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MVC_BookshelfContext() : base("name=MVC_BookshelfContext")
        {
        }

        public System.Data.Entity.DbSet<MVC_Bookshelf.Models.Book> Books { get; set; }

        public System.Data.Entity.DbSet<MVC_Bookshelf.Models.Category> Categories { get; set; }
    }
}
