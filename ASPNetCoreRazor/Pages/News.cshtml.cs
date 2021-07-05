using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNetCoreRazor.Pages
{
    public class NewsModel : PageModel
    {
        public List<NewsListItem> Items { get; set; }

        public class NewsListItem
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }

        public void OnGet()
        {
            Items = new List<NewsListItem>
            {
                new NewsListItem{Description = "asddsadsa", Title="423423"},
                new NewsListItem{Description = "asdds324432adsa", Title="42ttre3423"},
                new NewsListItem{Description = "as243dsadsa", Title="42t4r33423"}
            };
        }
    }
}
