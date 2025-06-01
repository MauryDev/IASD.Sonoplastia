namespace IASD.Sonoplastia.Utils
{
    public static class Github
    {
        public static string GetRawPath(string author, string repo, string branch, string path) =>
            $"https://raw.githubusercontent.com/{author}/{repo}/refs/heads/{branch}/{path}";
    }
}
