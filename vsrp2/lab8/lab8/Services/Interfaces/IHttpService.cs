namespace lab8.Services.Interfaces
{
    public interface IHttpService
    {
        IEnumerable<string>? Cookies { get; set; }

        T Send<T>(HttpMethod httpMethod, string requestUri, Dictionary<string, IEnumerable<string>>? headers = null);

        T Send<T, K>(HttpMethod httpMethod, string requestUri, K requestModel, Dictionary<string, IEnumerable<string>>? headers = null);

        HttpResponseMessage Send<T>(HttpMethod httpMethod, string requestUri, T model, Dictionary<string, IEnumerable<string>>? headers = null);

        HttpResponseMessage Send(HttpMethod httpMethod, string requestUri, Dictionary<string, IEnumerable<string>>? headers = null);
    }
}
