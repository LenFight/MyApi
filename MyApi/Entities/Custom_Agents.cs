namespace MyApi.Entities
{
    public class Custom_Agents
    {
        public int Id { get; set; }
        public string fullname { get; set; }
        public int number_certificate { get; set; }
        public List <CustomWarehouse>? warehouse { get; set; }
    }
}
