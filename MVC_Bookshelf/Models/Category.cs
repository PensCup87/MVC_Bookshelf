using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Bookshelf.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Display(Name="Category")]
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        /*Creating MODEL IS (NEED A CONNECTION TO BOOK MODEL) a drop list for the user to select a category
         so the user does not enter a category that is not in the DB*/
    }
}