using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WineStoreEntity.Models;

namespace WineStoreEntity.Pages.Contact
{
    public class ViewContactModel : PageModel
    {

        DatabaseContext Context;

        public ViewContactModel(DatabaseContext databasecontext)
        {
            Context = databasecontext;
        }

        public List<Contact_Data> contactList { get; set; }



        public void OnGet()
        {
            //this code is used to get the data from the database and pass to the linq list 
            var data = (from Contact in Context.Contact_Data
                        select Contact).ToList();

            contactList = data;


        }


        //this code is used to delete the record from the table 
        public ActionResult OnGetDelete(int? id)
        {

            if (id != null)
            {
                //compare the get id with the table 
                var data = (from contact in Context.Contact_Data
                            where contact.ID == id
                            select contact).SingleOrDefault();
                //remove the record from the table
                Context.Remove(data);
                Context.SaveChanges();
            }
            return RedirectToPage("ViewContact");
        }

    }
}