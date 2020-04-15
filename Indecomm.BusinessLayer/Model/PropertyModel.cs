using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indecomm.BusinessLayer.Model
{
    public class PropertyModel
    {
		public PropertyModel()
		{
			address = new Address();
			physical = new Physical();
			financial = new Financial();
		}
		public int Id { get; set; }
		public int accountId { get; set; }
		public string market { get; set; }
		public Address address { get; set; }

		public Physical physical { get; set; }

		public Financial financial { get; set; }

		//Gross Yield % ('Monthly Rent' * 12 / 'List Price') 
		[Display(Name = "Gross Yield")]
		[DisplayFormat(DataFormatString = "{0:0.00}%")]
		public double grossYield
		{
			get
			{
				return financial != null ? ((financial.MonthlyRent * 12) / financial.ListPrice) : 0;
			}
		}

		[Display(Name = "Address")]
		public string fullAddress
		{
			get
			{
				return String.Format("{0} {1} {2} {3}, {4}", this.address.Address1, this.address.City, this.address.State, this.address.Country, this.address.Zip);
			}
		}
	}
}
