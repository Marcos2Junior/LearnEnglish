using LearnEnglish.Desktop.Models;
using System.Text.Json;

namespace LearnEnglish.Desktop.Services
{
    public class LocalStorage
    {
        public LocalStorageInfo LocalStorageInfo { get; set; } = new LocalStorageInfo();

        public string FileInfoLocalStorage = Path.Combine(Constants.DirectoryApplicationData, "local_storage.config.json");

        public async Task SaveChangesAsync()
        {
            await File.WriteAllTextAsync(FileInfoLocalStorage, JsonSerializer.Serialize(LocalStorageInfo, new JsonSerializerOptions { WriteIndented = true, IgnoreReadOnlyProperties = true }));
        }

        private static LocalStorage _instancia;

        public static LocalStorage Instancia
        {
            get
            {
                _instancia ??= new LocalStorage();
                return _instancia;
            }

        }
        private LocalStorage()
        {
            if (File.Exists(FileInfoLocalStorage))
            {
                try
                {
                    LocalStorageInfo = JsonSerializer.Deserialize<LocalStorageInfo>(File.ReadAllText(FileInfoLocalStorage));
                }
                catch (Exception)
                {
                    File.Delete(FileInfoLocalStorage);
                }
            }
        }
    }

    public class LocalStorageInfo
    {
        public bool? IsDarkMode { get; set; }
        public List<HotKeyAttribute> HotKeys { get; set; } = new List<HotKeyAttribute>();
    }
}
