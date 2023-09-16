namespace DevPortfolioClient.Static
{
    public class APIEndpoints
    {
        
#if DEBUG
            internal const string ServerBaseUrl = "https://localhost:7204";
#else
        internal const string ServerBaseUrl = "https://appname.azurewebsites.net";
#endif

            internal readonly static string s_categories = $"{ServerBaseUrl}/api/categories";
            internal readonly static string s_imageUpload = $"{ServerBaseUrl}/api/imageupload";

    }
}
