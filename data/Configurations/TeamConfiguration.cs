using domain.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Configurations
{
  public  class TeamConfiguration: EntityTypeConfiguration<Team>
    {
        public TeamConfiguration()
        {
            HasRequired<Bibliotheque>(t => t.Bibliotheque).WithMany(t => t.Documents).HasForeignKey(t => t.BibliothequeFK);
        }
    }
}
