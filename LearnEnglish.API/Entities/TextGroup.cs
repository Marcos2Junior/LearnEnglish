namespace LearnEnglish.API.Entities
{
    public class TextGroup : BaseEntity
    {
        public string Name { get; set; }
        public List<Text> Texts { get; set; }
    }
}