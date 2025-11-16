using System;
using System.Collections.Generic;
using System.Linq;
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
    public class ChatbotService : WebService
    {
        private static readonly Dictionary<string, List<KeyValuePair<string, string>>> FaqData =
            new Dictionary<string, List<KeyValuePair<string, string>>>()
            {
                {
                    "Courier", new List<KeyValuePair<string, string>>()
                    {
                        new KeyValuePair<string, string>("How much does courier cost?", "Prices depend on weight, dimensions and type. Check the courier page."),
                        new KeyValuePair<string, string>("Do you ship internationally?", "Yes! We offer both domestic and international courier services.")
                    }
                },
                {
                    "Tracking", new List<KeyValuePair<string, string>>()
                    {
                        new KeyValuePair<string, string>("How can I track my parcel?", "Go to the main PostNet website then the Tracking page and enter your parcel number."),
                        new KeyValuePair<string, string>("My tracking number isn't working.", "Please wait a few hours after shipment.")
                    }
                },
                {
                    "Store Information", new List<KeyValuePair<string, string>>()
                    {
                        new KeyValuePair<string, string>("What are your operating hours?", "Mon-Fri: 08:00-17:00, Sat: 08:00-13:00, Sun: 9:00-13:00"),
                        new KeyValuePair<string, string>("Where are you located?", "Shop 21, 22 Kings Road Pinewalk Centre, Pinetown Durban, 3610"),
                        new KeyValuePair<string, string>("How to contact us?", "Phone: 031 702 5687 Email: pinetown@postnet.co.za")
                    }
                },
                {
                    "Order", new List<KeyValuePair<string, string>>()
                    {
                        new KeyValuePair<string, string>("Why is add product not working?", "Check stock if it is more than the number of products you want to add."),
                        new KeyValuePair<string, string>("How to cancel order?", "Please contact store to get assistance.")
                    }
                }
            };

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string Ask(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return "Please enter a message.";

            string lower = message.ToLower();

            // Search in FAQ
            foreach (var category in FaqData)
            {
                foreach (var faq in category.Value)
                {
                    if (lower.Contains(faq.Key.ToLower()))
                        return faq.Value;
                }
            }

            // Fallback
            return GenerateFallbackResponse(lower);
        }

        private string GenerateFallbackResponse(string msg)
        {
            if (msg.Contains("hello") || msg.Contains("hi"))
                return "Hello! How can I assist you today?";

            if (msg.Contains("price"))
                return "Pricing depends on the service. Please specify what you want a price for.";

            return "I'm not sure about that, but you can call us at 031 702 5687 or email pinetown@postnet.co.za.";
        }
    }
}
