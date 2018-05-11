using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NCSys.Web.Models
{
    public class NCSysWebContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public NCSysWebContext() : base("name=NCSysWebContext")
        {
        }

        public System.Data.Entity.DbSet<NCSys.Models.CUST> CUSTs { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.SERV> SERVs { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.ADDRESS> ADDRESSes { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.PARTY> PARTies { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.COMPETITOR> COMPETITORs { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.PARTY_ROLE> PARTY_ROLE { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.SERV_LOCATION> SERV_LOCATION { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.PARTY_SERV> PARTY_SERV { get; set; }
    }
}
