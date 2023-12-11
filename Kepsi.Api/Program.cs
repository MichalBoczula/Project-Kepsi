using KeepItShort.Persistance.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Text;

using KeepItShort.Persistance.Models;

using Kepsi.Api.Response;
using Kepsi.Bl.Interfaces;

using Newtonsoft.Json;

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

app.MapPost("/MakeItShortEmail", async () =>
{
    var email = "Subject: Special Thanks for Exceptional Service Dear Customer Service, I would like to express my sincere thanks for the incredibly positive shopping experience I had at your store. From entering the store to receiving the ordered product, everything was absolutely perfect. Your customer service deserves special recognition. You were always ready to answer my questions and resolve any doubts. Your politeness and professionalism truly set you apart from others. The product I purchased exceeded my expectations. The quality of craftsmanship and attention to detail are commendable. I'm glad I could trust your store, and I will certainly recommend it to family and friends. Thank you once again for taking the time to create such a unique shopping experience. You are true masters in the field of customer service! Best regards, Adam Nowak";
    var email2 =
        "  Dzieñ Dobry\r\n\r\nW dniu dzisiejszym zg³osi³a siê klientk Adam Nowak zam. 33-500 Krakow ul dluga 7/33\r\nW/w klientka jest spadkobierczyni¹ po zmar³ym mê¿u W³adys³awie Nowaku. Zrzek³a siê spadku. Obecnie spadek przechodzi wyrokiem SR w Londynie na Gminê Krakow.\r\nPP. Nowakowie posiadali kredyt który nie by³ sp³acany i zosta³ sprzedany przez nasz Bank firmie KRUK SA\r\nPan Adam ma obecnie raport kredytowy z kredytem o statusie umorzony i nie mo¿e skorzystaæ z ofert kredytowych.\r\nJe¿eli Pañstwa Firma wyst¹pi do Gminy Krakow z wnioskiem o zaspokojenie roszczeñ z tytu³u niesp³aconego kredytu przy sprzeda¿y nieruchomoœci po W³adys³awie Nowaku by³aby mo¿liwoœæ\r\nNaprawienia Raportu kredytowego klientki.\r\nW za³¹czeniu przesy³am Odpis wyroku dotycz¹cy spadku.\r\nPan Adam Nowak bêdzie oczekiwa³a na Pañstwa informacjê.\r\nAdam Nowak \r\nul dluga 7/33\r\n33-500 Krakow ";

    var emailCosTam = email2.Replace("\r\n", string.Empty);

    string openaiApiKey = @"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";

    string apiUrl = "https://api.openai.com/v1/chat/completions";

    string jsonData = $@"{{
            ""model"": ""gpt-3.5-turbo-1106"",
            ""response_format"": {{ ""type"": ""json_object"" }},
            ""messages"": [
              {{
                ""role"": ""system"",
                ""content"": ""Create summary of e-mail. Summary should be in json which has {{customerName, topic, summary}}. Summary in json has 1 sentence which consist of from crucial information. Response must be in polish language.""
              }},
              {{
                ""role"": ""user"",
                ""content"": ""This is e-mail to summarize: '{emailCosTam}'""
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

app.MapPost("/MakeItShortConversation", async () =>
    {
        var conversation =
            "Mail 1:\r\nSubject: Inquiry about Mortgage Options\r\n\r\nDear Mr. Karol Smith,\r\n\r\nI hope this email finds you well. My name is Natalie Portman, and I am currently exploring mortgage options for purchasing a home. I have heard positive reviews about Raven International Bank's mortgage services and would appreciate more information regarding the various mortgage products you offer.\r\n\r\nSpecifically, I am interested in learning about the interest rates, repayment terms, and any other relevant details that could help me make an informed decision. Additionally, if there are any special promotions or offers available, I would be grateful for that information as well.\r\n\r\nThank you in advance for your time and assistance. I look forward to hearing from you soon.\r\n\r\nBest regards,\r\nNatalie Portman\r\n59-900 London \r\n5th avenue 6/7\r\nnati@test.com\r\n\r\nMail 2:\r\nSubject: Response to Mortgage Inquiry\r\n\r\nDear Ms. Natalie Portman,\r\n\r\nThank you for reaching out and expressing interest in our mortgage products. My name is [Bank Representative], and I am pleased to assist you with any information you may need.\r\n\r\nOur mortgage options include competitive interest rates, flexible repayment terms, and various programs to suit individual needs. I have attached a brochure outlining our current offerings for your review.\r\n\r\nIf you have any specific questions or if there's additional information you'd like, feel free to let me know. I am here to help you make an informed decision.\r\n\r\nBest regards,\r\nSales representative Mr. Karol Smith,\r\nRaven International Bank\r\nKarolSmith@ravenbank.com";
        var refactoredConversation = conversation.Replace("\r\n", string.Empty);

        string openaiApiKey = @"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";

        string apiUrl = "https://api.openai.com/v1/chat/completions";

        string jsonData = $@"{{
            ""model"": ""gpt-3.5-turbo-1106"",
            ""response_format"": {{ ""type"": ""json_object"" }},
            ""messages"": [
              {{
                ""role"": ""system"",
                ""content"": ""Create summary of conversation. Conversation consist of emails. Emails are divided by mail and number. Summary should be in array of json. One json is one email. Each json consist of {{customerName, topic, address, email, summary}}. Summary in json has 1 sentence which consist of from crucial information. Response must be in polish language.""
              }},
              {{
                ""role"": ""user"",
                ""content"": ""This are e-mails with conversation to summarize: '{refactoredConversation}'""
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


app.MapGet("/ConversationWithEmails", async () =>
    {
        using (var scope = app.Services.CreateScope())
        {
            var dbManager = scope.ServiceProvider.GetRequiredService<IDbManager>();
            var conversations = await dbManager.GetConversationWithEmails();

            var conversation2 = conversations.First();
            var email = conversation2.Emails.Take(1).First();
            //var conversation = email.Select(x => x.Content).Aggregate("", (curr, next) => curr + ";mail;" + next);
            var refactoredConversation = email.Content.Replace("\r\n", string.Empty);

            string openaiApiKey = @"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";

            string apiUrl = "https://api.openai.com/v1/chat/completions";

            string jsonData = $@"{{
            ""model"": ""gpt-3.5-turbo-1106"",
            ""response_format"": {{ ""type"": ""json_object"" }},
            ""messages"": [
              {{
                ""role"": ""system"",
                ""content"": ""Create summary of conversation. Conversation consist of emails. Emails are divided by ;mail;. Summary should be in array of json. One json is one email. Each json consist of {{customerName, topic, phoneNumber, email, summary}}. Summary in json has 1 sentence which consist of from crucial information. Response must be in polish language. Response in Message object has content property. This property must be in json form, it's crucial to deserialize it easily to object in c#. So please don't put any unnecessary characters and white spaces into content object.""
              }},
              {{
                ""role"": ""user"",
                ""content"": ""This are e-mails with conversation to summarize: '{refactoredConversation}'""
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
                    var json = JsonConvert.DeserializeObject<GptResponse>(result);
                    GptContent customerInquiry = JsonConvert.DeserializeObject<GptContent>(json.choices.First().message.content);

                    RefactoredEmail refactoredEmail = new RefactoredEmail()
                                                          {
                                                              CustomerName = customerInquiry.customerName,
                                                              Topic = customerInquiry.topic,
                                                              EmailAddress = customerInquiry.email,
                                                              PhoneNumber = customerInquiry.phoneNumber,
                                                              Summary = customerInquiry.summary,
                                                              EmailId = email.Id,
                                                          };

                    var id = await dbManager.AddRefactoredEmail(refactoredEmail);
                    return $"{id}";
                }
                else
                {
                    return $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                }
            }


        }
    });



app.Run();