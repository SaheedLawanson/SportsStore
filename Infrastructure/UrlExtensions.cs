namespace SportsStore.Infrastructure {
    public static class UrlExtensions {
        public static String PathAndQuery(this HttpRequest request) => 
            request.QueryString.HasValue
                ? $"{request.Path}{request.QueryString}"
                : request.Path.ToString();
    }
}