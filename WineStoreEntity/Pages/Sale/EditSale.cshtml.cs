using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WineStoreEntity.Models;

namespace WineStoreEntity.Pages.Sale
{
    public class EditSaleModel : PageModel
    {
        DatabaseContext Context;
        public EditSaleModel(DatabaseContext databasecontext)
        {
            Context = databasecontext;
        }

        [BindProperty]
        public Sale_Data sale { get; set; }

        //get the record of the Employee to dislplay on loading the database
        public void OnGet(int? id)
        {
            if (id != null)
            {//get the details after comparing the id
                var data = (from Sale in Context.Sale_Data
                            where Sale.id == id
                            select Sale).SingleOrDefault();

                sale= data;
            }

        }


        //when user click on the update then the record is updated in the table 
        public ActionResult OnPost()
        {
            var saleData = sale;
            if (!ModelState.IsValid)
            {
                return RedirectToPage("ViewAllSale");
            }

            Context.Entry(saleData).Property(x => x.Name).IsModified = true;
            Context.Entry(saleData).Property(x => x.Product).IsModified = true;
            Context.Entry(saleData).Property(x => x.Qty).IsModified = true;
            Context.Entry(saleData).Property(x => x.Bill).IsModified = true;
            Context.Entry(saleData).Property(x => x.BuyDate).IsModified = true;

            Context.SaveChanges();
            return RedirectToPage("ViewAllSale");
        }


    }
}