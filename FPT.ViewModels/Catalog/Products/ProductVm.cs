using FPT.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FPT.ViewModels.Catalog.Products
{
    public class ProductVm
    {
        public int Id { set; get; }
  
        public DateTime DateCreated { set; get; }

        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }

        public string LanguageId { set; get; }

        public DateTime Start { set; get; }

        public DateTime End { set; get; }


        public string TrainingTypes { set; get; }
        public string TrainerEmail { set; get; }

        public string Address { set; get; }

        public bool? IsFeatured { get; set; }

        public string ThumbnailImage { get; set; }

        public List<string> Categories { get; set; } = new List<string>();
    }
}