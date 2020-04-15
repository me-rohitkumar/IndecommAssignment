using Indecomm.BusinessLayer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Indecomm.ApiServices.Repository
{
    public interface IPropertyRepository
    {
        List<PropertyModel> GetPropertyDetails();

        Task<int> AddProperty(PropertyModel post);
    }
}
