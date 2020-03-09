using System;
using System.Collections.Generic;
using System.Text;

namespace DapperTesting.DTOs
{
    public class NullCarDTO : CarDTO
    {
        public NullCarDTO()
        {
            Id = 0;
            Name = "Empty";
            Price = 0;
        }
        public override int Id { get; set; }
        public override string Name { get; set; }
        public override int Price { get; set; }
    }
}
