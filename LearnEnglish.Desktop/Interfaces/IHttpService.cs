namespace LearnEnglish.Desktop.Interfaces
{
    public interface IHttpService
    {
        Task<T> GetAsync<T>(string uri);
        Task<bool> PostAsync(string uri, object value);
    }
}
