using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace DrivingSchoolWebsite
{
    /// <summary>
    /// Summary description for ChatbotController
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ScriptService]
    public class ChatbotController : WebService
    {
        private static readonly Dictionary<string, List<KeyValuePair<string, string>>> FaqData =
            new Dictionary<string, List<KeyValuePair<string, string>>>()
            {
        {
            "Booking", new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("How do I book a driving lesson?", "You can book lessons through our website by first logging in with your email and password or register an account, select 'BOOK ONLINE' and thereafter you can select your preferred date, time and instructor based on your preferred licence code."),
                new KeyValuePair<string, string>("Can I reschedule a lesson?", "Yes! You can reschedule up to 24 hours before your lesson by logging into your account or contacting us.")
            }
        },
        {
            "Pricing", new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("How much does a driving lesson cost?", "Code 8: R200 per lesson. Code 10: R350 per lesson.")
            }
        },
        {
            "Instructors", new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("Who are your instructors?", "All our instructors are certified and experienced."),
                new KeyValuePair<string, string>("Can I choose my instructor?", "Yes! During booking, you can select your preferred instructor if available.")
            }
        },
        {
            "Driving Test", new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("Do you provide test preparation?", "Yes, we offer driving test preparation lessons tailored to your local licensing requirements."),
                new KeyValuePair<string, string>("Can you help me book my driving test?", "We guide you on booking your test, and we can book with the local licensing authority directly for you if need be.")
            }
        },
        {
            "General", new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("What are your operating hours?", "Mon-Sat: 11:00-17:00, Sundays & Public Holidays: Closed"),
                new KeyValuePair<string, string>("How can I contact the driving school?", "Phone: 084 678 6530 Email: arafismail075@gmail.com")
            }
        }
            };

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Xml)]
        public string Ask(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return "Please enter a message so I can assist you.";

            string lower = message.ToLower();

            // --- 1. Check FAQ dictionary first ---
            foreach (var category in FaqData)
            {
                foreach (var faq in category.Value)
                {
                    if (lower.Contains(faq.Key.ToLower()))
                        return faq.Value;
                }
            }

            // --- 2. Driving School System Prompt ---
            string systemPrompt = @"
You are an AI assistant for *Araf’s Driving School*.
You must answer ONLY based on the information below:

OPERATING HOURS:
- Mon–Sat: 11:00–17:00
- Sundays & Public Holidays: Closed

ADDRESS:
- 53 Cranbrook Road, Clayfield, Phoenix, 4068

LESSON TYPES & PRICES:
- Code 8: R200 per lesson
- Code 10: R350 per lesson

SERVICES:
- Driving lessons for Code 8 (light motor vehicles)
- Driving lessons for Code 10 (trucks/minibuses)
- Test preparation
- Assistance with booking driving tests
- Choosing your instructor during booking

CONTACT:
- Phone: 084 678 6530
- Email: arafismail075@gmail.com

BOOKING INFO:
- Lessons are booked ONLINE through the website
- You must log in or register an account first
- You can choose date, time, instructor, and licence code
- Rescheduling allowed up to 24 hours before lesson

RULES:
- If user asks anything unrelated to driving school services, politely decline
- Do NOT answer general knowledge questions
- If info is not listed above, say:
  'Please contact the driving school for more information at 084 678 6530.'
";

            // --- 3. Call OpenAI API ---
            try
            {
                using (var client = new HttpClient())
                {
                    string apiKey = ConfigurationManager.AppSettings["OpenAIKey"];
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                    var requestBody = new
                    {
                        model = "gpt-4o-mini",   // Stable + cheap + fast
                        messages = new[]
                        {
                    new { role = "system", content = systemPrompt },
                    new { role = "user", content = message }
                },
                        max_tokens = 300,
                        temperature = 0.4
                    };

                    var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");
                    var response = client.PostAsync("https://api.openai.com/v1/chat/completions", content).Result;
                    var responseJson = response.Content.ReadAsStringAsync().Result;

                    dynamic result = JsonConvert.DeserializeObject(responseJson);
                    string aiReply = result.choices[0].message.content;

                    return aiReply.Trim();
                }
            }
            catch
            {
                // --- 4. Fallback if API fails ---
                return "Sorry, I am having trouble answering that right now. Please try again later or contact us at 084 678 6530.";
            }
        }

    }
}
