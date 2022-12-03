namespace LearnEnglish.Desktop.Theme
{
    public interface ITheme
    {
        public string BackGroundPrimary { get; set; }
        public string BackGroundSecondary { get; set;}

        public string BackGroundInput { get; set; }
        public string ForeColorInput { get; set; }

        public string ForeColorPrimary { get; set; }
        public string ForeColorSecondary { get; set; }
    }
}
