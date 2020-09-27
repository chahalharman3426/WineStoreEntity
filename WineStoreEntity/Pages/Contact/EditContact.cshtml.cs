using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WineStoreEntity.Models;

namespace WineStoreEntity.Pages.Contact
{
    public class EditContactModel : PageModel
    {
        DatabaseContext Context;
        public EditContactModel(DatabaseContext databasecontext)
        {
            Context = databasecontext;
        }

        [BindProperty]
        public Contact_Data contact { get; set; }

        //get the record of the Employee to dislplay on loading the database
        public void OnGet(int? id)
        {
            if (id != null)
            {//get the details after comparing the id
                var data = (from Contact in Context.Contact_Data
                            where Contact.ID == id
                            select Contact).SingleOrDefault();

                contact = data;
            }

        }


        //when user click on the update then the record is updated in the table 
        public ActionResult OnPost()
        {
            var ContactData = contact;
            if (!ModelState.IsValid)
            {
                return RedirectToPage("ViewContact");
            }

            Context.Entry(ContactData).Property(x => x.Name).IsModified = true;
            Context.Entry(ContactData).Property(x => x.Email).IsModified = true;
            Context.Entry(ContactData).Property(x => x.Phone).IsModified = true;
            Context.Entry(ContactData).Property(x => x.Message).IsModified = true;

            Context.SaveChanges();
            return RedirectToPage("ViewContact");
        }

    }
}