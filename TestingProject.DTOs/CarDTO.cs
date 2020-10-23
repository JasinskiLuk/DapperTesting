using System.Collections.Generic;

namespace TestingProject.DTOs
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int DateId { get; set; }

        public DateTestDTO Dates { get; set; }
        public IEnumerable<ParameterDTO> Parameters { get; set; }
    }

    public class NullCarDTO : CarDTO
    {
        public NullCarDTO()
        {
            Id = -1;
            Name = "Empty";
            Price = 0;
        }
    }
}
