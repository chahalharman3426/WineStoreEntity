using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WineStoreEntity.Models;

namespace WineStoreEntity.Pages.Sale
{
    public class ViewAllSaleModel : PageModel
    {

        DatabaseContext Context;

        public ViewAllSaleModel(DatabaseContext databasecontext)
        {
            Context = databasecontext;
        }

        public List<Sale_Data> SaleList { get; set; }



        public void OnGet()
        {
            //this code is used to get the data from the database and pass to the linq list 
            var data = (from Sale in Context.Sale_Data
                        select Sale).ToList();

            SaleList = data;


        }


        //this code is used to delete the record from the table 
        public ActionResult OnGetDelete(int? id)
        {

            if (id != null)
            {
                //compare the get id with the table 
                var data = (from Sale in Context.Sale_Data
                            where Sale.id == id
                            select Sale).SingleOrDefault();
                //remove the record from the table
                Context.Remove(data);
                Context.SaveChanges();
            }
            return RedirectToPage("ViewAllSale");
        }


    }
}