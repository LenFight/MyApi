namespace MyApi.Entities
{
    public class Custom_Duty
    {
        public int Id { get; set; }

        public Custom_Warehouses? Custom_Warehouses { get; set; }

        public DateOnly date { get; set; }

        public int num_of_good { get; set; }
        public int id_Document_of_Good { get; set; }



    }
}
