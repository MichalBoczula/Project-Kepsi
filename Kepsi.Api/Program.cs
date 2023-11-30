using KeepItShort.Persistance.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddPersistance(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/MakeItShort", async () =>
//async ([FromBody] string email) =>
{
    var email = "Subject: Special Thanks for Exceptional Service Dear Customer Service, I would like to express my sincere thanks for the incredibly positive shopping experience I had at your store. From entering the store to receiving the ordered product, everything was absolutely perfect. Your customer service deserves special recognition. You were always ready to answer my questions and resolve any doubts. Your politeness and professionalism truly set you apart from others. The product I purchased exceeded my expectations. The quality of craftsmanship and attention to detail are commendable. I'm glad I could trust your store, and I will certainly recommend it to family and friends. Thank you once again for taking the time to create such a unique shopping experience. You are true masters in the field of customer service! Best regards, Adam Nowak";

    string openaiApiKey = @"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";

    string apiUrl = "https://api.openai.com/v1/chat/completions";

    string jsonData = $@"{{
            ""model"": ""gpt-3.5-turbo-1106"",
            ""response_format"": {{ ""type"": ""json_object"" }},
            ""messages"": [
              {{
                ""role"": ""system"",
                ""content"": ""Create summary of e-mail. Summary should be in json which has {{customerName, topic, summary}}. Summary in json has 1 sentence which consist of from crucial information.""
              }},
              {{
                ""role"": ""user"",
                ""content"": ""This is e-mail to summarize: '{email}'""
              }}
            ]
        }}";

    using (HttpClient client = new HttpClient())
    {
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", openaiApiKey);
        client.DefaultRequestHeaders
               .Accept
               .Add(new MediaTypeWithQualityHeaderValue("application/json"));


        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "relativeAddress");

        HttpResponseMessage response = await client.PostAsync(apiUrl, content);

        if (response.IsSuccessStatusCode)
        {
            string result = await response.Content.ReadAsStringAsync();
            return result;
        }
        else
        {
            return $"Error: {response.StatusCode} - {response.ReasonPhrase}";
        }
    }
});

app.Run();