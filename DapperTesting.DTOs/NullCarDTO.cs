namespace DapperTesting.DTOs
{
    public class NullCarDTO : CarDTO
    {
        public NullCarDTO()
        {
            Id = 0;
            Name = "Empty";
            Price = 0;
            Dates = new NullDateTestDTO();
        }
    }
}
