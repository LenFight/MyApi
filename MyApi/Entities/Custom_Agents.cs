namespace MyApi.Entities
{
    public class Custom_Agents
    {
        public int Custom_AgentsID { get; set; }
        public string fullname { get; set; }
        public int number_certificate { get; set; }

        public Custom_Warehouses? warehouses { get; set; }
    }
}
