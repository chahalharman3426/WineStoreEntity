using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WineStoreEntity.Models
{
    public class Sale_Data
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Enter Product")]
        public String Product { get; set; }


        [Required(ErrorMessage = "Enter Qty")]
        public String Qty { get; set; }

        [Required(ErrorMessage = "Enter Bill Amount")]
        public String Bill { get; set; }



        [Required(ErrorMessage = "Enter Buying Date")]
        public String BuyDate { get; set; }

    }
}
