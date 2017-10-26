using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Bookshelf.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        [MinLength(2), MaxLength(50)] /*Now Title Must have 2 characters, maximum 50*/
        public string Title { get; set; }
        [Display(Name= "Published Date")]
        public DateTime PublishedDate { get; set; } /*Has a Specific Format*/
        [MaxLength(500)]
        public string Description { get; set; }
        public string ISBN { get; set; }  /*Using String Because Not Using the Number for Math Purpose*/

        /*There is not a way to CONNECT CATEGORY MODEL TO BOOK MODEL
         A FOREIGN KEY Can Link .....then build after adding Foreign Key*/
        
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }


    }
}