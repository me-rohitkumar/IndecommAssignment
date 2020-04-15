using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Indecomm.ApiServices.Model.Dto
{
    [Table("Properties", Schema = "dbo")]
    public class Property
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PropertyId { get; set; }

        public string Address { get; set; }

        [Display(Name = "Year Built")]
        public int YearBuilt { get; set; }

        [Display(Name = "List Price")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public double ListPrice { get; set; }

        [Display(Name = "Monthly Rent")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        public double MonthlyRent { get; set; }
    }
}
