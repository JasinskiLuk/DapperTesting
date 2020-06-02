using System;

namespace DapperTesting.DTOs
{
    public class AttachmentDTO
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string OriginalFileName { get; set; }
        public string FilePath { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
