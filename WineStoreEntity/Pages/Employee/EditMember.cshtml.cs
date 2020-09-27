using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WineStoreEntity.Models;

namespace WineStoreEntity.Pages.Employee
{
    public class EditMemberModel : PageModel
    {
        DatabaseContext Context;
        public EditMemberModel(DatabaseContext databasecontext)
        {
            Context = databasecontext;
        }

        [BindProperty]
        public Employee_Table Employee { get; set; }

        //get the record of the Employee to dislplay on loading the database
        public void OnGet(int? id)
        {
            if (id != null)
            {//get the details after comparing the id
                var data = (from Employee in Context.Employee_Table
                            where Employee.id == id
                            select Employee).SingleOrDefault();

                Employee = data;
            }

        }


        //when user click on the update then the record is updated in the table 
        public ActionResult OnPost()
        {
            var EmployeeData= Employee;
            if (!ModelState.IsValid)
            {
                return RedirectToPage("ViewAllMember");
            }

            Context.Entry(EmployeeData).Property(x => x.Name).IsModified = true;
            Context.Entry(EmployeeData).Property(x => x.Designation).IsModified = true;
            Context.Entry(EmployeeData).Property(x => x.Phone).IsModified = true;
            Context.Entry(EmployeeData).Property(x => x.Address).IsModified = true;
            Context.Entry(EmployeeData).Property(x => x.Salary).IsModified = true;
            
            Context.SaveChanges();
            return RedirectToPage("ViewAllMember");
        }

    }
}