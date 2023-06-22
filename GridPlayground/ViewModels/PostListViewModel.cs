using System.Text.Json;
using System.Net.Http.Json;

namespace GridPlayground;

public partial class PostListViewModel
{
    public List<Post> PostItems { get; private set; }

    private const string RestURL = "https://jsonplaceholder.typicode.com/posts";
    private HttpClient httpClient;
    private JsonSerializerOptions serializerOptions;

    public async Task<List<Post>> GetPostData()
    {
        PostItems = new List<Post>();
        httpClient = new HttpClient();

        Uri PostListURI = new Uri(string.Format(RestURL, string.Empty));
        HttpResponseMessage response = await httpClient.GetAsync(PostListURI);
        if (response.IsSuccessStatusCode)
        {
            PostItems = await response.Content.ReadFromJsonAsync<List<Post>>();
        }

        return PostItems;
    }
}


