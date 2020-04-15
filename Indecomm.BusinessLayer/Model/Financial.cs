using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indecomm.BusinessLayer.Model
{
	public class Financial
	{
		[Display(Name = "List Price")]
		[DisplayFormat(DataFormatString = "{0:C2}")]
		public double ListPrice { get; set; }
		[Display(Name = "Monthly Rent")]
		[DisplayFormat(DataFormatString = "{0:C2}")]
		public double MonthlyRent { get; set; }
	}
}
