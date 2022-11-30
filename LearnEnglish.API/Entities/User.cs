namespace LearnEnglish.API.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public bool IsTranslated { get; set; }
    }
}
