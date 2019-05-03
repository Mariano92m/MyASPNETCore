using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using MyCoreApplication.Core;
using MyCoreApplication.Data;

namespace MyCoreApplication.Pages.Bimbo
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IBimboProductData bimboProductData;

        public string Message { get; set; }
        public IEnumerable<BimboProduct> BimboProduct { get; set; }

        public IndexModel(IConfiguration config, IBimboProductData bimboProductData)
        {
            this.config = config;
            this.bimboProductData = bimboProductData;
        }

        public void OnGet()
        {
            Message = "Hello Bitch";
            BimboProduct = bimboProductData.GetAll();
        }
    }
}