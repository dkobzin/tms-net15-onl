namespace WebApiHT25and26.Extensions
{
    public static class AppLibrary
    {
        public async static Task SendHtml(this HttpResponse response, string nameHtml, string format = "html")
        {
            response.ContentType = "text/html";
            await response.SendFileAsync($"wwwroot/html/{nameHtml}.{format}");
        }
        
    }
}
