using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace electronicshop.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }

        //Foreign key for MainCategory
        public int MainCategoryId { get; set; }
        public MainCategory MainCategory { get; set; }
    }
}