namespace LearnEnglish.API.Entities
{
    public class Text : BaseEntity
    {
        public string Value { get; set; }
        public string Translate { get; set; }
        public DateTime DateTime { get; set; }
        public int TextGroupID { get; set; }
        public TextGroup TextGroup { get; set; }
    }
}
