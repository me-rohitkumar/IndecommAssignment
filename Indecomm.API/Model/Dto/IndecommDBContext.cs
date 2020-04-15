using Microsoft.EntityFrameworkCore;

namespace Indecomm.ApiServices.Model.Dto
{
    public class IndecommDBContext : DbContext
    {
        public DbSet<Property> Properties { get; set; }

        public IndecommDBContext(DbContextOptions<IndecommDBContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer(@"data source=DESKTOP-H7IC0AK\MSSQL;initial catalog=IndecommServiceDB; persist security info = True;Integrated Security = SSPI; ");
        //    }
        //}
    }
}
