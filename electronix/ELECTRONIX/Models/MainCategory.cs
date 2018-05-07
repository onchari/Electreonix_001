using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace electronicshop.Models
{
    public class MainCategory
    {
        [Key]
        public int MainCategoryId { get; set; }

        public string MainCategoryName { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}