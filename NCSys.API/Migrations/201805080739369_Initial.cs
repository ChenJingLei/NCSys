namespace NCSys.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ADDRESSes",
                c => new
                    {
                        ADDRESS_ID = c.Int(nullable: false, identity: true),
                        LONGITUDE = c.Double(nullable: false),
                        LATITUDE = c.Double(nullable: false),
                        PROVINCE_NAME = c.String(maxLength: 30),
                        CITY_NAME = c.String(maxLength: 30),
                        DISTRICT_NAME = c.String(maxLength: 30),
                        STREET_NAME = c.String(maxLength: 30),
                        STREET_NBR = c.String(maxLength: 30),
                        COMMUNITY_NAME = c.String(maxLength: 30),
                        BUILDING_NAME = c.String(maxLength: 30),
                        UNIT_NBR = c.String(maxLength: 30),
                        ROOM_NBR = c.String(maxLength: 30),
                        DETAIL = c.String(maxLength: 300),
                        POSTCODE = c.String(maxLength: 30),
                        latn_id = c.Int(nullable: false),
                        STATE = c.String(maxLength: 3),
                    })
                .PrimaryKey(t => t.ADDRESS_ID);
            
            CreateTable(
                "dbo.BILLING_CYCLE",
                c => new
                    {
                        BILLING_CYCLE_ID = c.Int(nullable: false, identity: true),
                        BILLING_CYCLE_TYPE_ID = c.Int(nullable: false),
                        LAST_BILLING_CYCLE_ID = c.Int(nullable: false),
                        CYCLE_BEGIN_DATE = c.DateTime(nullable: false),
                        CYCLE_END_DATE = c.DateTime(nullable: false),
                        AMOUNT = c.Double(nullable: false),
                        BLOCK_DATE = c.DateTime(nullable: false),
                        STATE = c.String(),
                        STATE_DATE = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BILLING_CYCLE_ID)
                .ForeignKey("dbo.BILLING_CYCLE_TYPE", t => t.BILLING_CYCLE_TYPE_ID, cascadeDelete: true)
                .ForeignKey("dbo.BILLING_CYCLE", t => t.LAST_BILLING_CYCLE_ID)
                .Index(t => t.BILLING_CYCLE_TYPE_ID)
                .Index(t => t.LAST_BILLING_CYCLE_ID);
            
            CreateTable(
                "dbo.BILLING_CYCLE_TYPE",
                c => new
                    {
                        BILLING_CYCLE_TYPE_ID = c.Int(nullable: false, identity: true),
                        REGION_ID = c.Int(nullable: false),
                        BILLING_CYCLE_TYPE_NAME = c.String(maxLength: 50),
                        CYCLE_UNIT = c.String(maxLength: 3),
                        UNIT_COUNT = c.Int(nullable: false),
                        CYCLE_DURATION = c.Int(nullable: false),
                        CYCLE_DURATION_DAYS = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BILLING_CYCLE_TYPE_ID);
            
            CreateTable(
                "dbo.COMPETITORs",
                c => new
                    {
                        PARTY_ROLE_ID = c.Int(nullable: false, identity: true),
                        COMPETITOR_CODE = c.String(maxLength: 30),
                        COMPETITOR_NAME = c.String(maxLength: 30),
                        COMPETITOR_DESC = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.PARTY_ROLE_ID)
                .ForeignKey("dbo.PARTY_ROLE", t => t.PARTY_ROLE_ID)
                .Index(t => t.PARTY_ROLE_ID);
            
            CreateTable(
                "dbo.PARTY_ROLE",
                c => new
                    {
                        PARTY_ROLE_ID = c.Int(nullable: false, identity: true),
                        PARTY_ROLE_NAME = c.String(maxLength: 50),
                        PASSWORD = c.String(maxLength: 64),
                        PARTY_ROLE_TYPE = c.String(maxLength: 3),
                        ORG_MANEGER = c.String(maxLength: 1),
                        PARTY_ID = c.Int(nullable: false),
                        office_ID = c.Int(nullable: false),
                        STATE = c.String(maxLength: 3),
                        EFF_DATE = c.DateTime(nullable: false),
                        EXP_DATE = c.DateTime(nullable: false),
                        update_time = c.DateTime(nullable: false),
                        incor_starttime = c.DateTime(nullable: false),
                        login_count = c.Int(nullable: false),
                        limit_count = c.Int(nullable: false),
                        default_menu_code = c.String(maxLength: 10),
                        machine_id = c.Int(nullable: false),
                        contact_nbr = c.String(maxLength: 31),
                        third_party_role_id = c.String(maxLength: 20),
                        crm_staff_code = c.String(maxLength: 20),
                        MENU_CODE = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.PARTY_ROLE_ID)
                .ForeignKey("dbo.PARTies", t => t.PARTY_ID, cascadeDelete: true)
                .Index(t => t.PARTY_ID);
            
            CreateTable(
                "dbo.PARTies",
                c => new
                    {
                        PARTY_ID = c.Int(nullable: false, identity: true),
                        PARTY_NAME = c.String(maxLength: 50),
                        EFF_DATE = c.DateTime(nullable: false),
                        STATE = c.String(maxLength: 3),
                        STATE_DATE = c.DateTime(nullable: false),
                        region_id = c.Int(nullable: false),
                        PARTY_SOURCE_DESC = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.PARTY_ID);
            
            CreateTable(
                "dbo.CUST_TYPE",
                c => new
                    {
                        CUST_TYPE_ID = c.Int(nullable: false, identity: true),
                        CUST_TYPE_NAME = c.String(maxLength: 50),
                        PARENT_TYPE_ID = c.Int(nullable: false),
                        TYPE_LEVEL = c.Int(nullable: false),
                        PARENT_CUST_TYPE_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CUST_TYPE_ID)
                .ForeignKey("dbo.CUST_TYPE", t => t.PARENT_CUST_TYPE_ID)
                .Index(t => t.PARENT_CUST_TYPE_ID);
            
            CreateTable(
                "dbo.CUSTs",
                c => new
                    {
                        CUST_ID = c.Int(nullable: false, identity: true),
                        CUST_NAME = c.String(maxLength: 250),
                        INDUSTRY_ID = c.Int(nullable: false),
                        CUST_LOCATION = c.Int(nullable: false),
                        PARENT_ID = c.Int(nullable: false),
                        CUST_CODE = c.String(maxLength: 20),
                        STATE = c.String(maxLength: 3),
                        EFF_DATE = c.DateTime(nullable: false),
                        EXP_DATE = c.DateTime(nullable: false),
                        PASSWD = c.String(maxLength: 30),
                        CUST_CATEGORY = c.Int(nullable: false),
                        AGREEMENT_ID = c.Int(nullable: false),
                        IS_VIP = c.String(maxLength: 6),
                        LATN_ID = c.Int(nullable: false),
                        IMP_CUST_TYPE = c.String(maxLength: 9),
                        CUST_CLASS = c.String(maxLength: 9),
                        CUST_TYPE = c.String(maxLength: 3),
                        CHARGE_PROVINCE_CODE = c.String(maxLength: 4),
                        CHARGE_LATN_ID = c.Int(nullable: false),
                        CUST_SUB_BRAND = c.String(maxLength: 4),
                        CUST_BRAND = c.String(maxLength: 4),
                        CUST_SERVD_LEVEL = c.String(maxLength: 3),
                        SALE_ORGANIZE_ID = c.Int(nullable: false),
                        COUNTY_TYPE = c.Int(nullable: false),
                        MANAGE_LEVEL = c.Int(nullable: false),
                        GRID_CODE = c.String(maxLength: 30),
                        NEW_CUST_TYPE = c.String(maxLength: 6),
                        AREA_ID = c.Int(nullable: false),
                        MANAGE_CUST_ID = c.Int(nullable: false),
                        GROUP_GRADE = c.String(maxLength: 3),
                        CUST_TYPE_ID = c.Int(nullable: false),
                        REGION_SALE_CODE = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CUST_ID)
                .ForeignKey("dbo.CUST_TYPE", t => t.CUST_TYPE_ID, cascadeDelete: true)
                .ForeignKey("dbo.MANAGE_CUST_INFO", t => t.MANAGE_CUST_ID, cascadeDelete: true)
                .Index(t => t.MANAGE_CUST_ID)
                .Index(t => t.CUST_TYPE_ID);
            
            CreateTable(
                "dbo.MANAGE_CUST_INFO",
                c => new
                    {
                        MANAGE_CUST_ID = c.Int(nullable: false, identity: true),
                        MANAGE_CUST_NAME = c.String(maxLength: 200),
                        MANAGE_CUST_CODE = c.String(maxLength: 30),
                        MANAGE_CUST_DESC = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.MANAGE_CUST_ID);
            
            CreateTable(
                "dbo.EXCHANGEs",
                c => new
                    {
                        EXCHANGE_ID = c.Int(nullable: false, identity: true),
                        REGION_ID = c.Int(nullable: false),
                        EXCHANGE_CODE = c.String(maxLength: 30),
                        EXCHANGE_NAME = c.String(maxLength: 50),
                        ACC_NBR_BEGIN = c.String(maxLength: 20),
                        ACC_NBR_END = c.String(maxLength: 20),
                        STATE = c.String(maxLength: 3),
                        EFF_DATE = c.DateTime(nullable: false),
                        EXP_DATE = c.DateTime(nullable: false),
                        area_id = c.Int(nullable: false),
                        product_family_id = c.Int(nullable: false),
                        acc_nbr_tag = c.Int(nullable: false),
                        SITE_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EXCHANGE_ID)
                .ForeignKey("dbo.REGIONs", t => t.REGION_ID, cascadeDelete: true)
                .Index(t => t.REGION_ID);
            
            CreateTable(
                "dbo.REGIONs",
                c => new
                    {
                        REGION_ID = c.Int(nullable: false, identity: true),
                        PARENT_REGION_ID = c.Int(nullable: false),
                        REGION_LEVEL = c.String(maxLength: 3),
                        REGION_NAME = c.String(maxLength: 50),
                        REGION_DESC = c.String(maxLength: 250),
                        REGION_CODE = c.String(maxLength: 20),
                        PROVINCE_CODE = c.String(maxLength: 4),
                        uni_code = c.String(maxLength: 4),
                    })
                .PrimaryKey(t => t.REGION_ID)
                .ForeignKey("dbo.REGIONs", t => t.PARENT_REGION_ID)
                .Index(t => t.PARENT_REGION_ID);
            
            CreateTable(
                "dbo.PARTY_SERV",
                c => new
                    {
                        PARTY_SERV_ID = c.Int(nullable: false, identity: true),
                        PARTY_ID = c.Int(nullable: false),
                        SERV_ID = c.Int(nullable: false),
                        STATE = c.String(maxLength: 10),
                        LAST_UPDATE_DATE = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PARTY_SERV_ID)
                .ForeignKey("dbo.PARTies", t => t.PARTY_ID, cascadeDelete: true)
                .ForeignKey("dbo.SERVs", t => t.SERV_ID, cascadeDelete: true)
                .Index(t => t.PARTY_ID)
                .Index(t => t.SERV_ID);
            
            CreateTable(
                "dbo.SERVs",
                c => new
                    {
                        SERV_ID = c.Int(nullable: false, identity: true),
                        CUST_ID = c.Int(nullable: false),
                        PRODUCT_ID = c.Int(nullable: false),
                        AGREEMENT_ID = c.Int(nullable: false),
                        BILLING_CYCLE_TYPE_ID = c.Int(nullable: false),
                        BILLING_MODE_ID = c.Int(nullable: false),
                        COMPLETED_DATE = c.DateTime(nullable: false),
                        RENT_DATE = c.DateTime(nullable: false),
                        CREATE_DATE = c.DateTime(nullable: false),
                        EFF_DATE = c.DateTime(nullable: false),
                        EXP_DATE = c.DateTime(nullable: false),
                        STATE = c.String(maxLength: 3),
                        STATE_DATE = c.DateTime(nullable: false),
                        CUST_CATEGORY = c.Int(nullable: false),
                        CREDIT_LIMIT_PLAN_ID = c.Int(nullable: false),
                        BONUS_PLAN_ID = c.Int(nullable: false),
                        HOT_BILLING_FLAG = c.Int(nullable: false),
                        LATN_ID = c.Int(nullable: false),
                        USER_SUB_BRAND = c.String(maxLength: 10),
                        USER_BRAND = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.SERV_ID)
                .ForeignKey("dbo.BILLING_CYCLE_TYPE", t => t.BILLING_CYCLE_TYPE_ID, cascadeDelete: true)
                .ForeignKey("dbo.CUSTs", t => t.CUST_ID, cascadeDelete: true)
                .ForeignKey("dbo.PRODUCTs", t => t.PRODUCT_ID, cascadeDelete: true)
                .Index(t => t.CUST_ID)
                .Index(t => t.PRODUCT_ID)
                .Index(t => t.BILLING_CYCLE_TYPE_ID);
            
            CreateTable(
                "dbo.PRODUCTs",
                c => new
                    {
                        PRODUCT_ID = c.Int(nullable: false, identity: true),
                        PRODUCT_PROVIDER_ID = c.Int(nullable: false),
                        PRICING_PLAN_ID = c.Int(nullable: false),
                        product_family_id = c.Int(nullable: false),
                        PRODUCT_NAME = c.String(maxLength: 50),
                        product_comments = c.String(maxLength: 250),
                        PRODUCT_TYPE = c.String(maxLength: 3),
                        PRODUCT_CLASSIFICATION = c.String(maxLength: 3),
                        PRODUCT_CODE = c.String(maxLength: 15),
                        STATE = c.String(maxLength: 3),
                        EFF_DATE = c.DateTime(nullable: false),
                        EXP_DATE = c.DateTime(nullable: false),
                        limit_num = c.Int(nullable: false),
                        no_rent_flag = c.Int(nullable: false),
                        CREATED_DATE = c.DateTime(nullable: false),
                        STATE_DATE = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PRODUCT_ID);
            
            CreateTable(
                "dbo.PRIVILEGEs",
                c => new
                    {
                        PRIVILEGE_ID = c.Int(nullable: false, identity: true),
                        PARENT_PRG_ID = c.Int(nullable: false),
                        PRIVILEGE_NAME = c.String(),
                        PRIVILEGE_TYPE = c.String(),
                        PRIVILEGE_DESC = c.String(),
                        PRIVILEGE_CODE = c.String(),
                        PARTY_ROLE_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PRIVILEGE_ID)
                .ForeignKey("dbo.PRIVILEGEs", t => t.PARENT_PRG_ID)
                .ForeignKey("dbo.PARTY_ROLE", t => t.PARTY_ROLE_ID, cascadeDelete: true)
                .Index(t => t.PARENT_PRG_ID)
                .Index(t => t.PARTY_ROLE_ID);
            
            CreateTable(
                "dbo.ROLE_PRIVILEGE",
                c => new
                    {
                        ROLE_ID = c.Int(nullable: false),
                        PRIVILEGE_ID = c.Int(nullable: false),
                        state = c.String(),
                        State_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ROLE_ID)
                .ForeignKey("dbo.PRIVILEGEs", t => t.PRIVILEGE_ID, cascadeDelete: true)
                .ForeignKey("dbo.ROLEs", t => t.ROLE_ID)
                .Index(t => t.ROLE_ID)
                .Index(t => t.PRIVILEGE_ID);
            
            CreateTable(
                "dbo.ROLEs",
                c => new
                    {
                        ROLE_ID = c.Int(nullable: false, identity: true),
                        ROLE_NAME = c.String(maxLength: 50),
                        ROLE_DESC = c.String(maxLength: 250),
                        party_role_id = c.Int(nullable: false),
                        region_id = c.Int(nullable: false),
                        state = c.String(maxLength: 3),
                        State_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ROLE_ID);
            
            CreateTable(
                "dbo.SERV_IDENTIFICATION",
                c => new
                    {
                        SERV_ID = c.Int(nullable: false),
                        AGREEMENT_ID = c.Int(nullable: false),
                        SEQ_NBR = c.Int(nullable: false),
                        product_family_id = c.Int(nullable: false),
                        AREA_CODE = c.String(maxLength: 15),
                        ACC_NBR = c.String(maxLength: 31),
                        EFF_DATE = c.DateTime(nullable: false),
                        EXP_DATE = c.DateTime(nullable: false),
                        physical_nbr = c.String(maxLength: 31),
                        latn_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SERV_ID)
                .ForeignKey("dbo.SERVs", t => t.SERV_ID)
                .Index(t => t.SERV_ID);
            
            CreateTable(
                "dbo.SERV_LOCATION",
                c => new
                    {
                        SERV_ID = c.Int(nullable: false),
                        SEQ_NBR = c.Int(nullable: false),
                        AGREEMENT_ID = c.Int(nullable: false),
                        ADDRESS_ID = c.Int(nullable: false),
                        REGION_ID = c.Int(nullable: false),
                        EXCHANGE_ID = c.Int(nullable: false),
                        EFF_DATE = c.DateTime(nullable: false),
                        EXP_DATE = c.DateTime(nullable: false),
                        serv_type_id = c.Int(nullable: false),
                        billing_type_id = c.Int(nullable: false),
                        latn_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SERV_ID)
                .ForeignKey("dbo.ADDRESSes", t => t.ADDRESS_ID, cascadeDelete: true)
                .ForeignKey("dbo.EXCHANGEs", t => t.EXCHANGE_ID, cascadeDelete: true)
                .ForeignKey("dbo.SERVs", t => t.SERV_ID)
                .Index(t => t.SERV_ID)
                .Index(t => t.ADDRESS_ID)
                .Index(t => t.EXCHANGE_ID);
            
            CreateTable(
                "dbo.STAFFs",
                c => new
                    {
                        PARTY_ROLE_ID = c.Int(nullable: false),
                        STAFF_CODE = c.String(maxLength: 15),
                        STAFF_DESC = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.PARTY_ROLE_ID)
                .ForeignKey("dbo.PARTY_ROLE", t => t.PARTY_ROLE_ID)
                .Index(t => t.PARTY_ROLE_ID);
            
            CreateTable(
                "dbo.STAFF_PRIVILEGE",
                c => new
                    {
                        STAFF_PRIVILEGE_ID = c.Int(nullable: false, identity: true),
                        PARTY_ROLE_ID = c.Int(nullable: false),
                        REGION_ID = c.Int(nullable: false),
                        STATE = c.String(),
                        EFF_DATE = c.DateTime(nullable: false),
                        EXP_DATE = c.DateTime(nullable: false),
                        PRIVILEGE_ID = c.Int(nullable: false),
                        REGION_TYPE = c.String(),
                        PRIVILEGE_TYPE = c.String(),
                    })
                .PrimaryKey(t => t.STAFF_PRIVILEGE_ID)
                .ForeignKey("dbo.PARTY_ROLE", t => t.PARTY_ROLE_ID, cascadeDelete: true)
                .ForeignKey("dbo.PRIVILEGEs", t => t.PRIVILEGE_ID, cascadeDelete: true)
                .ForeignKey("dbo.REGIONs", t => t.REGION_ID, cascadeDelete: true)
                .Index(t => t.PARTY_ROLE_ID)
                .Index(t => t.REGION_ID)
                .Index(t => t.PRIVILEGE_ID);
            
            CreateTable(
                "dbo.STAFF_ROLE",
                c => new
                    {
                        PARTY_ROLE_ID = c.Int(nullable: false),
                        ROLE_ID = c.Int(nullable: false),
                        REGION_ID = c.Int(nullable: false),
                        STATE = c.String(maxLength: 3),
                        EFF_DATE = c.DateTime(nullable: false),
                        EXP_DATE = c.DateTime(nullable: false),
                        REGION_TYPE = c.String(maxLength: 3),
                    })
                .PrimaryKey(t => t.PARTY_ROLE_ID)
                .ForeignKey("dbo.PARTY_ROLE", t => t.PARTY_ROLE_ID)
                .ForeignKey("dbo.REGIONs", t => t.REGION_ID, cascadeDelete: true)
                .ForeignKey("dbo.ROLEs", t => t.ROLE_ID, cascadeDelete: true)
                .Index(t => t.PARTY_ROLE_ID)
                .Index(t => t.ROLE_ID)
                .Index(t => t.REGION_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.STAFF_ROLE", "ROLE_ID", "dbo.ROLEs");
            DropForeignKey("dbo.STAFF_ROLE", "REGION_ID", "dbo.REGIONs");
            DropForeignKey("dbo.STAFF_ROLE", "PARTY_ROLE_ID", "dbo.PARTY_ROLE");
            DropForeignKey("dbo.STAFF_PRIVILEGE", "REGION_ID", "dbo.REGIONs");
            DropForeignKey("dbo.STAFF_PRIVILEGE", "PRIVILEGE_ID", "dbo.PRIVILEGEs");
            DropForeignKey("dbo.STAFF_PRIVILEGE", "PARTY_ROLE_ID", "dbo.PARTY_ROLE");
            DropForeignKey("dbo.STAFFs", "PARTY_ROLE_ID", "dbo.PARTY_ROLE");
            DropForeignKey("dbo.SERV_LOCATION", "SERV_ID", "dbo.SERVs");
            DropForeignKey("dbo.SERV_LOCATION", "EXCHANGE_ID", "dbo.EXCHANGEs");
            DropForeignKey("dbo.SERV_LOCATION", "ADDRESS_ID", "dbo.ADDRESSes");
            DropForeignKey("dbo.SERV_IDENTIFICATION", "SERV_ID", "dbo.SERVs");
            DropForeignKey("dbo.ROLE_PRIVILEGE", "ROLE_ID", "dbo.ROLEs");
            DropForeignKey("dbo.ROLE_PRIVILEGE", "PRIVILEGE_ID", "dbo.PRIVILEGEs");
            DropForeignKey("dbo.PRIVILEGEs", "PARTY_ROLE_ID", "dbo.PARTY_ROLE");
            DropForeignKey("dbo.PRIVILEGEs", "PARENT_PRG_ID", "dbo.PRIVILEGEs");
            DropForeignKey("dbo.PARTY_SERV", "SERV_ID", "dbo.SERVs");
            DropForeignKey("dbo.SERVs", "PRODUCT_ID", "dbo.PRODUCTs");
            DropForeignKey("dbo.SERVs", "CUST_ID", "dbo.CUSTs");
            DropForeignKey("dbo.SERVs", "BILLING_CYCLE_TYPE_ID", "dbo.BILLING_CYCLE_TYPE");
            DropForeignKey("dbo.PARTY_SERV", "PARTY_ID", "dbo.PARTies");
            DropForeignKey("dbo.EXCHANGEs", "REGION_ID", "dbo.REGIONs");
            DropForeignKey("dbo.REGIONs", "PARENT_REGION_ID", "dbo.REGIONs");
            DropForeignKey("dbo.CUSTs", "MANAGE_CUST_ID", "dbo.MANAGE_CUST_INFO");
            DropForeignKey("dbo.CUSTs", "CUST_TYPE_ID", "dbo.CUST_TYPE");
            DropForeignKey("dbo.CUST_TYPE", "PARENT_CUST_TYPE_ID", "dbo.CUST_TYPE");
            DropForeignKey("dbo.COMPETITORs", "PARTY_ROLE_ID", "dbo.PARTY_ROLE");
            DropForeignKey("dbo.PARTY_ROLE", "PARTY_ID", "dbo.PARTies");
            DropForeignKey("dbo.BILLING_CYCLE", "LAST_BILLING_CYCLE_ID", "dbo.BILLING_CYCLE");
            DropForeignKey("dbo.BILLING_CYCLE", "BILLING_CYCLE_TYPE_ID", "dbo.BILLING_CYCLE_TYPE");
            DropIndex("dbo.STAFF_ROLE", new[] { "REGION_ID" });
            DropIndex("dbo.STAFF_ROLE", new[] { "ROLE_ID" });
            DropIndex("dbo.STAFF_ROLE", new[] { "PARTY_ROLE_ID" });
            DropIndex("dbo.STAFF_PRIVILEGE", new[] { "PRIVILEGE_ID" });
            DropIndex("dbo.STAFF_PRIVILEGE", new[] { "REGION_ID" });
            DropIndex("dbo.STAFF_PRIVILEGE", new[] { "PARTY_ROLE_ID" });
            DropIndex("dbo.STAFFs", new[] { "PARTY_ROLE_ID" });
            DropIndex("dbo.SERV_LOCATION", new[] { "EXCHANGE_ID" });
            DropIndex("dbo.SERV_LOCATION", new[] { "ADDRESS_ID" });
            DropIndex("dbo.SERV_LOCATION", new[] { "SERV_ID" });
            DropIndex("dbo.SERV_IDENTIFICATION", new[] { "SERV_ID" });
            DropIndex("dbo.ROLE_PRIVILEGE", new[] { "PRIVILEGE_ID" });
            DropIndex("dbo.ROLE_PRIVILEGE", new[] { "ROLE_ID" });
            DropIndex("dbo.PRIVILEGEs", new[] { "PARTY_ROLE_ID" });
            DropIndex("dbo.PRIVILEGEs", new[] { "PARENT_PRG_ID" });
            DropIndex("dbo.SERVs", new[] { "BILLING_CYCLE_TYPE_ID" });
            DropIndex("dbo.SERVs", new[] { "PRODUCT_ID" });
            DropIndex("dbo.SERVs", new[] { "CUST_ID" });
            DropIndex("dbo.PARTY_SERV", new[] { "SERV_ID" });
            DropIndex("dbo.PARTY_SERV", new[] { "PARTY_ID" });
            DropIndex("dbo.REGIONs", new[] { "PARENT_REGION_ID" });
            DropIndex("dbo.EXCHANGEs", new[] { "REGION_ID" });
            DropIndex("dbo.CUSTs", new[] { "CUST_TYPE_ID" });
            DropIndex("dbo.CUSTs", new[] { "MANAGE_CUST_ID" });
            DropIndex("dbo.CUST_TYPE", new[] { "PARENT_CUST_TYPE_ID" });
            DropIndex("dbo.PARTY_ROLE", new[] { "PARTY_ID" });
            DropIndex("dbo.COMPETITORs", new[] { "PARTY_ROLE_ID" });
            DropIndex("dbo.BILLING_CYCLE", new[] { "LAST_BILLING_CYCLE_ID" });
            DropIndex("dbo.BILLING_CYCLE", new[] { "BILLING_CYCLE_TYPE_ID" });
            DropTable("dbo.STAFF_ROLE");
            DropTable("dbo.STAFF_PRIVILEGE");
            DropTable("dbo.STAFFs");
            DropTable("dbo.SERV_LOCATION");
            DropTable("dbo.SERV_IDENTIFICATION");
            DropTable("dbo.ROLEs");
            DropTable("dbo.ROLE_PRIVILEGE");
            DropTable("dbo.PRIVILEGEs");
            DropTable("dbo.PRODUCTs");
            DropTable("dbo.SERVs");
            DropTable("dbo.PARTY_SERV");
            DropTable("dbo.REGIONs");
            DropTable("dbo.EXCHANGEs");
            DropTable("dbo.MANAGE_CUST_INFO");
            DropTable("dbo.CUSTs");
            DropTable("dbo.CUST_TYPE");
            DropTable("dbo.PARTies");
            DropTable("dbo.PARTY_ROLE");
            DropTable("dbo.COMPETITORs");
            DropTable("dbo.BILLING_CYCLE_TYPE");
            DropTable("dbo.BILLING_CYCLE");
            DropTable("dbo.ADDRESSes");
        }
    }
}
