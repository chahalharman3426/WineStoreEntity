using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WineStoreEntity.Models
{
    public class Contact_Data
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Enter Phone")]
        public String Phone { get; set; }

        [Required(ErrorMessage = "Enter Message")]
        public String Message { get; set; }


    }
}
