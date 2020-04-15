using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indecomm.BusinessLayer.Model
{
	public class Physical
	{
		[Display(Name = "Year Built")]
		public int YearBuilt { get; set; }
	}
}
