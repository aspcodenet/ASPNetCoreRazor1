using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNetCoreRazor.Pages
{
    public class RandomNumberModel : PageModel
    {
        private static Random _rnd = new Random();
        public int RandomTal { get; set; }

        public string Tid { get; set; }
        // Dessutom ska du Skriva ut aktuell tid i formatet 12:22

        public void OnGet()
        {
            Tid = DateTime.Now.ToString("HH:mm");
            RandomTal = _rnd.Next(0, 300000);
        }
    }
}
