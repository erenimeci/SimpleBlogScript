using BS.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Model.Mapping.EntityFramework
{
    public class UserMapping : EntityTypeConfiguration<User>
    {

        public UserMapping()
        {
            HasKey(e => e.ID);

            Property(e => e.Name).IsRequired().HasMaxLength(50);
            Property(e => e.Surname).IsRequired().HasMaxLength(50);
            
        }

    }
}
