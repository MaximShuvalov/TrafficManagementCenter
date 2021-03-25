using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class ClassAppeal
    {
        [Key]
        public long Key {get;set;}
        public string Name {get;set;}
    }
}