namespace Model
{
    public class SubtypeAppeal
    {
        public long Key { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public TypeAppeal Type { get; set; }
    }
}