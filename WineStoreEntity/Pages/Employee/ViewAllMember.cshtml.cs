using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WineStoreEntity.Models;

namespace WineStoreEntity.Pages.Employee
{
    public class ViewAllMemberModel : PageModel
    {
        DatabaseContext Context;

        public ViewAllMemberModel(DatabaseContext databasecontext)
        {
            Context = databasecontext;
        }

        public List<Employee_Table> EmployeeList { get; set; }



        public void OnGet()
        {
            //this code is used to get the data from the database and pass to the linq list 
            var data = (from Employeelist in Context.Employee_Table
                        select Employeelist).ToList();

            EmployeeList = data;


        }


        //this code is used to delete the record from the table 
        public ActionResult OnGetDelete(int? id)
        {

            if (id != null)
            {
                //compare the get id with the table 
                var data = (from Employee_Table in Context.Employee_Table
                            where Employee_Table.id == id
                            select Employee_Table).SingleOrDefault();
                //remove the record from the table
                Context.Remove(data);
                Context.SaveChanges();
            }
            return RedirectToPage("ViewAllMember");
        }

    }
}