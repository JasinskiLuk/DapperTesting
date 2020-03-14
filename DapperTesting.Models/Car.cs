namespace DapperTesting.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int DateTestId { get; set; }

        public DateTest Dates { get; set; }
    }
}
