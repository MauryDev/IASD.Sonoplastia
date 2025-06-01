namespace IASD.Sonoplastia.Utils;

public static class CorsProxy
{
    public static string GetFullUrl(string url)
    {
        var urlencoded = System.Net.WebUtility.UrlEncode(url);
        return $"https://corsproxy.io/?url={urlencoded}";
    }
}
