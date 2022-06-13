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
        public DbSet<Custom_Warehouses> Custom_Warehouses { get; set; }
        public DbSet<Goods_Type> goods_Types { get; set; }
        public DbSet<Custom_Duty> custom_Duty { get; set; }

    }

    public class Custom_Agents 
    {

        public string fullname { get; set; }
        public int number_certificate { get; set; }

        public Custom_Warehouses? warehouses { get; set; }
    }
    public class Custom_Warehouses 
    {
        public int id { get; set; }

        public Goods_Type? type { get; set; }
    }

    public class Goods_Type 
    {
        public int Goods_ID { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
        public int duty_for_unit { get; set; }
    }

    public class Custom_Duty 
    {
        public int Custom_DutyID { get; set; }

        public Custom_Warehouses? Custom_Warehouses { get; set; }

        public DateOnly date { get; set; }

        public int num_of_good { get; set; }
        public int id_Document_of_Good { get; set; }

        

    }
}
