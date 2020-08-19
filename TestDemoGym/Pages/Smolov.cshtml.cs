using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestDemoGym.Pages
{
    public class SmolovModel : PageModel
    {
        public string CurrentMax { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            //this takes the input and prints in console
            //need to store it and access it in the client side programming for the program
            CurrentMax = Request.Form["currentmax"];
            
            Console.WriteLine(CurrentMax);
        }
    }
}