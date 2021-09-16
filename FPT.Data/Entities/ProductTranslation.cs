using System;
using System.Collections.Generic;
using System.Text;

namespace FPT.Data.Entities
{
    public class ProductTranslation
    {
        public int Id { set; get; }
        public int ProductId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }

        public string TrainingTypes { set; get; }
        public string TrainerEmail { set; get; }



        public string Address { set; get; }

        public string Details { set; get; }
        public string LanguageId { set; get; }


        public DateTime Start { set; get; }
        public DateTime End { set; get; }

        public Product Product { get; set; }

        public Language Language { get; set; }

    }
}
