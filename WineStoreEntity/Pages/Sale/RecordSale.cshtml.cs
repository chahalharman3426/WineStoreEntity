using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WineStoreEntity.Models;

namespace WineStoreEntity.Pages.Sale
{
    public class RecordSaleModel : PageModel
    {
        //use the getter setter to pass the value to the class
        [BindProperty]
        public Sale_Data Sale { get; set; }

        //crate the obect ofthe database class
        DatabaseContext context;

        //creating the default constrcutor of the clas
        public RecordSaleModel(DatabaseContext database)
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
            var sale_Data = Sale;
            if (!ModelState.IsValid)
            {
                return RedirectToPage("ViewAllSale");
            }
            Sale.id = 0;
            var result = context.Add(Sale);
            context.SaveChanges();
            return RedirectToPage("ViewAllSale");
        }
    }
}