using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class TypeAppeal
    {
        [Key]
        public int Key { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
    }
}