namespace Kepsi.Api.Response
{
    public class GptResponse
    {
        public string id { get; set; }
        public string model { get; set; }
        public List<GptChoice> choices { get; set; }
    }
}
