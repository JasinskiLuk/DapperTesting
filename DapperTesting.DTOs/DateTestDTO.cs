using System;

namespace DapperTesting.DTOs
{
    public class DateTestDTO
    {
        public int Id { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime DateTime1 { get; set; }
        public DateTime DateTime2 { get; set; }

        public CarDTO Cars { get; set; }
    }
}
