namespace MyApi.Entities
{
    public class CustomDuty
    {
        public int Id { get; set; }
        public List <CustomWarehouse>?  Custom_Warehouses { get; set; }
        public DateOnly date { get; set; }
        public int num_of_good { get; set; }
        public int id_Document_of_Good { get; set; }



    }
}
