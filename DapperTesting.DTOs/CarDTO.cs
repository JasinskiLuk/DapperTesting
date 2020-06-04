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

    public class NullCarDTO : CarDTO
    {
        public NullCarDTO()
        {
            Id = -1;
            Name = "Empty";
            Price = -1;
            Dates = new NullDateTestDTO();
        }
    }
}
