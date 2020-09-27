using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WineStoreEntity.Models;

namespace WineStoreEntity.Pages.Purchase
{
    public class ViewAllPurchaseModel : PageModel
    {
        DatabaseContext Context;

        public ViewAllPurchaseModel(DatabaseContext databasecontext)
        {
            Context = databasecontext;
        }

        public List<Purchase_Data> purchases { get; set; }



        public void OnGet()
        {
            //this code is used to get the data from the database and pass to the linq list 
            var data = (from Purchase in Context.Purchase_Data
                        select Purchase).ToList();
            purchases = data;
        }


        //this code is used to delete the record from the table 
        public ActionResult OnGetDelete(int? id)
        {

            if (id != null)
            {
                //compare the get id with the table 
                var data = (from Purchase in Context.Purchase_Data
                            where Purchase.id == id
                            select Purchase).SingleOrDefault();
                //remove the record from the table
                Context.Remove(data);
                Context.SaveChanges();
            }
            return RedirectToPage("ViewAllPurchase");
        }

    }
}