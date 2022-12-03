namespace LearnEnglish.Desktop
{
    public static class Constants
    {
        public static string DirectoryApplicationData
        {
            get
            {
                var dir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "learn_english_application");
                Directory.CreateDirectory(dir);
                return dir;
            }
        }
    }
}
