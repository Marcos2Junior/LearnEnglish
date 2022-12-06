namespace LearnEnglish.Desktop.Models
{
    [AttributeUsage(AttributeTargets.Field)]
    public class HotKeyAttribute : Attribute
    {
        public HotKeyType HotKeyType { get; set; }
        public string DescriptionKey { get; set; }
        public Keys Key1 { get; set; }
        public Keys Key2 { get; set; }
        public Keys Key3 { get; set; }

        public HotKeyAttribute(HotKeyType hotKeyType, string descriptionKey, Keys key1, Keys key2 = Keys.None, Keys key3 = Keys.None)
        {
            HotKeyType = hotKeyType;
            DescriptionKey = descriptionKey;
            Key1 = key1;
            Key2 = key2;
            Key3 = key3;
        }
        public HotKeyAttribute()
        {
        }
    }

    public enum HotKeyType
    {
        [HotKey(Close, "Close", Keys.Escape)]
        Close = 1,

        [HotKey(Show, "Show application", Keys.Control, Keys.Space)]
        Show = 2,

        [HotKey(ChangeTranslate, "Change translate", Keys.F1)]
        ChangeTranslate = 3,

        [HotKey(CreateNewTranslate, "Create new translate", Keys.Enter)]
        CreateNewTranslate = 4,

        [HotKey(ChangeTheme, "Change theme", Keys.F2)]
        ChangeTheme = 5,
    }
}
