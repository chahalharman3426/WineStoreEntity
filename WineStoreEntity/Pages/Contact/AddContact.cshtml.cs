using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WineStoreEntity.Models;

namespace WineStoreEntity.Pages.Contact
{
    public class AddContactModel : PageModel
    {
        //use the getter setter to pass the value to the class
        [BindProperty]
        public Contact_Data contact { get; set; }

        //crate the obect ofthe database class
        DatabaseContext context;

        //creating the default constrcutor of the clas
        public AddContactModel(DatabaseContext database)
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
            var Contact_Data = contact;
            if (!ModelState.IsValid)
            {
                return RedirectToPage("ViewContact");
            }
            contact.ID = 0;
            var result = context.Add(contact);
            context.SaveChanges();
            return RedirectToPage("ViewContact");
        }
    }
}