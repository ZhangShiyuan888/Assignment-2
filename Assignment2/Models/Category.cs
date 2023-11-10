﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        //[Required(ErrorMessage = "The category name cannot be blank")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a category name between 3 and 50 characters in length")]
        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Please enter a category name beginning with a capital" +
        //    "letter and made up of letters and spaces only")]
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}