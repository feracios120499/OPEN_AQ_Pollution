using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPEN_AQ_Pollution.DataBase
{
    public class PollutionConfiguration : EntityTypeConfiguration<Pollution>
    {
        public PollutionConfiguration()
        {
            Property(i => i.Id).HasColumnName("Id").HasColumnOrder(0);
            Property(i => i.Country).HasColumnName("Country");
            Property(i => i.City).HasColumnName("City");
            Property(i => i.Location).HasColumnName("Location");
            Property(i => i.Parameter).HasColumnName("Parameter");
            Property(i => i.Unit).HasColumnName("Unit");
            Property(i => i.Value).HasColumnName("Value");
            Property(i => i.LastUpdate).HasColumnName("LastUpdate");
        }
    }
}
