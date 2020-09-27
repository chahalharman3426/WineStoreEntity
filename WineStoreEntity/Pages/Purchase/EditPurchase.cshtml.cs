using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WineStoreEntity.Models;

namespace WineStoreEntity.Pages.Purchase
{
    public class EditPurchaseModel : PageModel
    {
        DatabaseContext Context;
        public EditPurchaseModel(DatabaseContext databasecontext)
        {
            Context = databasecontext;
        }

        [BindProperty]
        public Purchase_Data purchase { get; set; }

        //get the record of the Employee to dislplay on loading the database
        public void OnGet(int? id)
        {
            if (id != null)
            {//get the details after comparing the id
                var data = (from Purchase in Context.Purchase_Data
                            where Purchase.id == id
                            select Purchase).SingleOrDefault();

                purchase = data;
            }

        }


        //when user click on the update then the record is updated in the table 
        public ActionResult OnPost()
        {
            var PurchaseData = purchase;
            if (!ModelState.IsValid)
            {
                return RedirectToPage("ViewAllPurchase");
            }

            Context.Entry(PurchaseData).Property(x => x.Company).IsModified = true;
            Context.Entry(PurchaseData).Property(x => x.Category).IsModified = true;
            Context.Entry(PurchaseData).Property(x => x.Price).IsModified = true;
            Context.Entry(PurchaseData).Property(x => x.Qty).IsModified = true;
            Context.Entry(PurchaseData).Property(x => x.PurchaseDate).IsModified = true;

            Context.SaveChanges();
            return RedirectToPage("ViewAllPurchase");
        }

    }
}