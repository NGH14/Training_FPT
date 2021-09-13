using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FPT.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
 

        [Required(ErrorMessage = "Product name is requirement")]
        public string Name { set; get; }

        public string Description { set; get; }
        public string Details { set; get; }

        public string LanguageId { set; get; }

        [DataType(DataType.Date)]
        public DateTime Start { set; get; }

        [DataType(DataType.Date)]
        public DateTime End { set; get; }

        public string TrainingTypes { set; get; }
        public string TrainerEmail { set; get; }

        public string Address { set; get; }


        public bool? IsFeatured { get; set; }

        public IFormFile ThumbnailImage { get; set; }
    }
}