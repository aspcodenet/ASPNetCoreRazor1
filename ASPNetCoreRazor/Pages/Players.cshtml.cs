using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNetCoreRazor.Pages
{
    public class PlayersModel : PageModel
    {
        public List<string> Players { get; set; }



        public void OnGet()
        {
            Players = new List<string>
            {
                "Mats Sundin",
                "Peter Forsberg",
                "Anders Eldebrink",
                "Niklas Lidström"
            };
        }
    }
}
