using Indecomm.ApiServices.Model.Dto;
using Indecomm.BusinessLayer.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Indecomm.ApiServices.Repository
{
    public class PropertyRepository : IPropertyRepository
    {
        IndecommDBContext db;
        public PropertyRepository(IndecommDBContext _db)
        {
            db = _db;
        }

        public async Task<int> AddProperty(PropertyModel post)
        {
            if (db != null)
            {
                Property propertyData = new Property
                {
                    Address = post.address.Address1,
                    YearBuilt = Convert.ToInt32(post.physical.YearBuilt),
                    ListPrice = Convert.ToDouble(post.financial.ListPrice),
                    MonthlyRent = Convert.ToDouble(post.financial.MonthlyRent)
                };
                await db.Properties.AddAsync(propertyData);
                await db.SaveChangesAsync();

                return propertyData.PropertyId;
            }

            return 0;
        }

        /// <summary>
        /// this method is used to fetch the property json results
        /// </summary>
        /// <returns></returns>
        public List<PropertyModel> GetPropertyDetails()
        {
            var dataResult = new List<PropertyModel>();
            string url = "http://dev1-sample.azurewebsites.net/properties.json";
            using (var client = new HttpClient())
            {
                var uri = new Uri(url);

                var response = client.GetAsync(uri).Result;

                if (!response.IsSuccessStatusCode)
                    throw new Exception(response.ToString());

                //get the property json result
                var responseContent = response.Content;
                var responseString = responseContent.ReadAsStringAsync().Result;

                JObject propertyDataResult = JObject.Parse(responseString);

                // get JSON result objects into a list
                IList<JToken> jsonPropertyResults = propertyDataResult["properties"].Children().ToList();

                foreach (JToken result in jsonPropertyResults)
                {
                    // JToken.ToObject is a helper method that uses JsonSerializer internally
                    var jsonResult = result.ToObject<PropertyModel>();
                    dataResult.Add(jsonResult);
                }

                return dataResult;
            }
        }
    }
}
