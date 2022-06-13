using System.Data.Entity;
using MyApi.Entities;
namespace MyApi
{
    class DataBase : DbContext
    {
        public  DataBase() 
            : base("Customs")
        { }

        public DbSet<Custom_Agents> Custom_Agents { get; set; }
        public DbSet<CustomWarehouse> Custom_Warehouses { get; set; }
        public DbSet<GoodsType> goods_Types { get; set; }
        public DbSet<CustomDuty> custom_Duty { get; set; }

    }

    
}
