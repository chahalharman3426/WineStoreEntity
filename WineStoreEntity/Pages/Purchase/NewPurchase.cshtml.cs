using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WineStoreEntity.Models;

namespace WineStoreEntity.Pages.Purchase
{
    public class NewPurchaseModel : PageModel
    {
        //use the getter setter to pass the value to the class
        [BindProperty]
        public Purchase_Data purchase { get; set; }

        //crate the obect ofthe database class
        DatabaseContext context;

        //creating the default constrcutor of the clas
        public NewPurchaseModel(DatabaseContext database)
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
            var Purchase_Data =purchase;
            if (!ModelState.IsValid)
            {
                return RedirectToPage("ViewAllPurchase");
            }
            purchase.id = 0;
            var result = context.Add(Purchase_Data);
            context.SaveChanges();
            return RedirectToPage("ViewAllPurchase");
        }

    }
}