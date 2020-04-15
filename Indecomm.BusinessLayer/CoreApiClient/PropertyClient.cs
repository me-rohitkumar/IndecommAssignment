using Indecomm.BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indecomm.BusinessLayer.CoreApiClient
{
    public partial class ApiClient
    {
        public async Task<List<PropertyModel>> GetClietProperty()
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "ClientService/GetAllProperty"));
            return await GetAsync<List<PropertyModel>>(requestUrl);
        }

        public async Task<string> SaveProperty(PropertyModel model)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, "ClientService/AddProperty"));
            return await SaveDataAsync<string>(requestUrl, model);
            //return await PostAsync<PropertyModel>(requestUrl, model);
        }
    }
}

