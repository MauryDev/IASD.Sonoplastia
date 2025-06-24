using System.Text.Json.Serialization;

namespace GeneratorAPI.Data;
public class VideoInfo
{
    public class UrlInfo
    {
        [JsonPropertyName("type")]
        public string? Type { get; set; }
        [JsonPropertyName("href")]
        public string? Href { get; set; }
        [JsonIgnore]
        public string Url
        {
            get
            {
                if (Href is null)
                {
                    return string.Empty;
                }
                return Type switch
                {
                    "yt" => $"https://www.youtube.com/embed/{Href}",
                    "img_yt" => $"https://img.youtube.com/vi/{Href}/sddefault.jpg",
                    "dl" => $"https://www.daniellocutor.com.br/wp-content/uploads/{Href}",
                    _ => Href,
                };
               
            }
        }
    }
    [JsonPropertyName("titulo")]
    public string? Titulo { get; set; }
    [JsonPropertyName("image")]
    public UrlInfo? Image { get; set; }
    [JsonPropertyName("descricao")]
    public string? Descricao { get; set; }
    [JsonPropertyName("url")]
    public UrlInfo? Url { get; set; }
    [JsonPropertyName("data")]
    public string? Data { get; set; }
}
