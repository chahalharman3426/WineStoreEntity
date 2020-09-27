using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WineStoreEntity.Models;

namespace WineStoreEntity.Pages.Employee
{
    public class RegisterEmployeeModel : PageModel
    {
        //use the getter setter to pass the value to the class
        [BindProperty]
        public Employee_Table employee { get; set; }
        
        //crate the obect ofthe database class
        DatabaseContext context;

        //creating the default constrcutor of the clas
        public RegisterEmployeeModel(DatabaseContext database)
        {
            context = database;
        }


        public void OnGet()
        {

        }

        public ActionResult OnPost()
        {
            //while clicking on the submit button if all the data is in the valid state 
            //then add the record into the table 
            var employee_Data = employee;
            if (!ModelState.IsValid)
            {
                return RedirectToPage("ViewAllMember");
            }
            employee.id = 0;
            var result = context.Add(employee);
            context.SaveChanges();
            return RedirectToPage("ViewAllMember");
        }

    }
}