using System;

namespace TestingProject.DTOs
{
    public class DateTestDTO
    {
        public int Id { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime DateTime1 { get; set; }
        public DateTime DateTime2 { get; set; }

        public CarDTO Cars { get; set; }
    }

    public class NullDateTestDTO : DateTestDTO
    {
        public NullDateTestDTO()
        {
            Id = -1;
            Date1 = DateTime.MinValue;
            DateTime1 = DateTime.MinValue;
            DateTime2 = DateTime.MinValue;
            Cars = new NullCarDTO();
        }
    }
}
