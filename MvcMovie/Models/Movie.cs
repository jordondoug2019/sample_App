using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models 
{
    public class Movie{
        // Key is used to declare primary key 
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idMovie {get; set;}
        [Display(Name=" Enter Movie Code ")]
        [StringLength(20)]
        [Required(ErrorMessage="{0} is required field")]
        public string movieCode {get; set;}

        [Display(Name=" Enter Movie Type ")]
        [StringLength(50)]
        [Required(ErrorMessage="{0} is required field")]
        public string movieType {get; set;}

        [Display(Name=" Enter Movie Description ")]
        [StringLength(150)]
        public string description {get; set;}

        [Display(Name=" Unit Price ")]
        [DisplayFormat(DataFormatString="{0:C}")]
        [Required(ErrorMessage="{0} is required field")]
        public decimal unitPrice {get; set;}

        [Display(Name=" Quantity in Stock")]
        [StringLength(20)]
        [Required(ErrorMessage="{0} is required field")]
        public int qtyInStock {get; set;}
    }
}