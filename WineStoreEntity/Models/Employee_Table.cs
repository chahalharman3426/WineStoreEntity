using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace WineStoreEntity.Models
{
    public class Employee_Table
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Enter Designation")]
        public String Designation { get; set; }

        [Required(ErrorMessage = "Enter Phone Number")]
        public String Phone { get; set; }


        [Required(ErrorMessage = "Enter Address")]
        public String Address { get; set; }


        [Required(ErrorMessage = "Enter Salary")]
        public String Salary { get; set; }



    }
}
