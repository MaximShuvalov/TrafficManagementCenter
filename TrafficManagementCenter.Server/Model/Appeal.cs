using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Appeal
    {
        [Key]
        public long Key { get; set; }
        
        [ForeignKey("Subtype")]
        public long SubtypeId { get; set; }
        public SubtypeAppeal Subtype { get; set; }
        
        [ForeignKey("ClassAppeal")]
        public long ClassAppealId { get; set; }
        public ClassAppeal ClassAppeal { get; set; }
        public string Email { get; set; }
        public string Text { get; set; }
        public string Attachment { get; set; }
    }
}