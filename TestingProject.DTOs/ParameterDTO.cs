namespace TestingProject.DTOs
{
    public class ParameterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class NullParameterDTO : ParameterDTO
    {
        public NullParameterDTO()
        {
            Id = -1;
            Name = "Empty";
            Value = "Empty";
        }
    }
}
