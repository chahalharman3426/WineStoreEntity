using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WineStoreEntity.Models
{
    public class Purchase_Data
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Enter Name of the Company")]
        public String Company { get; set; }

        [Required(ErrorMessage = "Enter Category")]
        public String Category { get; set; }

        [Required(ErrorMessage = "Enter Price")]
        public String Price { get; set; }


        [Required(ErrorMessage = "Enter Qty")]
        public String Qty { get; set; }


        [Required(ErrorMessage = "Enter Date")]
        public String PurchaseDate { get; set; }


    }
}
