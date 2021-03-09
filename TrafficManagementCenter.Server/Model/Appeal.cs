using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Appeal
    {
        [Key]
        public long Key { get; set; }
        public SubtypeAppeal Subtype { get; set; }
        public ClassAppeal ClassAppeal { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public string Attachment { get; set; }
    }
}