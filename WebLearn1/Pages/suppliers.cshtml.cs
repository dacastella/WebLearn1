using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContextLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebLearn1.Pages
{
    public class suppliersModel : PageModel
    {
        private Northwind db;

        public suppliersModel(Northwind injectedContext)

        {

            db = injectedContext;

        }
        public IEnumerable<string> Suppliers { get; set; }
        public void OnGet()
        {
            Suppliers = db.Suppliers.Select(s => s.CompanyName);
        }
    }
}
