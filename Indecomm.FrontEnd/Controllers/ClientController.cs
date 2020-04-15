using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Indecomm.BusinessLayer.Model;
using Indecomm.FrontEnd.Factory;
using Indecomm.FrontEnd.Models;
using Indecomm.FrontEnd.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Indecomm.FrontEnd.Controllers
{
    public class ClientController : Controller
    {
        private readonly IOptions<AppSettingsModel> appSettings;

        public ClientController(IOptions<AppSettingsModel> options)
        {
            appSettings = options;
            ApplicationSettings.WebApiUrl = appSettings.Value.WebApiBaseUrl;
        }

        // GET: PropertyList
        [HttpGet]
        public async Task<IActionResult> PropertyList()
        {
            var data = await ApiClientFactory.Instance.GetClietProperty();
            return View(data);
        }

        // POST: Client/Create
        [HttpPost]
        public async Task<JsonResult> Create(string address, string yearBuilt, string listPrice, string monthlyRent)
        {
            var model = new PropertyModel()
            {
                address = new Address()
                {
                    Address1 = address
                },
                physical = new Physical()
                {
                    YearBuilt = Convert.ToInt32(yearBuilt),
                },
                financial = new Financial()
                {
                    ListPrice = Convert.ToDouble(listPrice),
                    MonthlyRent = Convert.ToDouble(monthlyRent)
                }
            };
            var response = await ApiClientFactory.Instance.SaveProperty(model);

            var message = (response != null) ? "Data saved successfully" : "something went wrong";
            return Json(new { status = message });
            }
    }
}