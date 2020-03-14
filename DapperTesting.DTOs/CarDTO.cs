namespace DapperTesting.DTOs
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int DateId { get; set; }

        public DateTestDTO Dates { get; set; }
    }
}
