using System.Text.Json.Serialization;

namespace GridPlayground;

public class Post
{
    [JsonPropertyName("userId")]
    public int UserID { get; set; }

    [JsonPropertyName("id")]
    public int ID { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("body")]
    public string Body { get; set; }
}


