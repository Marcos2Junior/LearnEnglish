namespace LearnEnglish.Desktop.Interfaces
{
    public interface IHttpService
    {
        Task<T> GetAsync<T>(string uri, CancellationToken cancellationToken);
        Task<bool> PostAsync(string uri, object value, CancellationToken cancellationToken);
    }
}
