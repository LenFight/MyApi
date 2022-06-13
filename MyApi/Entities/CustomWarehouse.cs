namespace MyApi.Entities
{
    public class CustomWarehouse
    {
        public int Id { get; set; }
        public List<GoodsType>? type { get; set; }
    }
}
