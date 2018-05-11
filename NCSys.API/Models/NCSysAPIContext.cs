using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NCSys.API.Models
{
    public class NCSysAPIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public NCSysAPIContext() : base("name=NCSysAPIContext")
        {
        }

        public System.Data.Entity.DbSet<NCSys.Models.CUST> CUSTs { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.SERV> SERVs { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.PRODUCT> PRODUCTs { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.ADDRESS> ADDRESSes { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.PARTY> PARTies { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.ROLE> ROLEs { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.EXCHANGE> EXCHANGEs { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.REGION> REGIONs { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.COMPETITOR> COMPETITORs { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.PRIVILEGE> PRIVILEGEs { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.STAFF_PRIVILEGE> STAFF_PRIVILEGE { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.ROLE_PRIVILEGE> ROLE_PRIVILEGE { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.CUST_TYPE> CUST_TYPE { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.MANAGE_CUST_INFO> MANAGE_CUST_INFO { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.SERV_IDENTIFICATION> SERV_IDENTIFICATION { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.SERV_LOCATION> SERV_LOCATION { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.BILLING_CYCLE> BILLING_CYCLE { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.BILLING_CYCLE_TYPE> BILLING_CYCLE_TYPE { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.PARTY_ROLE> PARTY_ROLE { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.PARTY_SERV> PARTY_SERV { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.STAFF> STAFF { get; set; }

        public System.Data.Entity.DbSet<NCSys.Models.STAFF_ROLE> STAFF_ROLE { get; set; }



    }
}
