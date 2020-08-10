using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace UniversitySystemGreyHat.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Please provide Department Code")]
        

        [DisplayName("Code")]
        public string DepartmentCode { get; set; }


        [Required(ErrorMessage = "Please provide Department Name")]
        [DisplayName("Name")]
        public string DepartmentName { get; set; }

    }

     //[Required(ErrorMessage = "An Album Title is required")]
     //   [DisplayFormat(ConvertEmptyStringToNull = false)]
     //   [StringLength(160, MinimumLength = 2)]
     //   public string Title { get; set; }

     //   [Range(0.01, 100.00, ErrorMessage = "Price must be between 0.01 and 100.00")]
     //   [DataType(DataType.Currency)]
     //   public decimal Price { get; set; }

     //   [DisplayName("Album Art URL")]
     //   [DataType(DataType.ImageUrl)]
     //   [StringLength(1024)]
}