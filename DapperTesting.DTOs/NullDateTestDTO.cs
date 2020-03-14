using System;

namespace DapperTesting.DTOs
{
    public class NullDateTestDTO : DateTestDTO
    {
        public NullDateTestDTO()
        {
            Id = 0;
            Date1 = DateTime.MinValue;
            DateTime1 = DateTime.MinValue;
            DateTime2 = DateTime.MinValue;
            Cars = new NullCarDTO();
        }
    }
}
