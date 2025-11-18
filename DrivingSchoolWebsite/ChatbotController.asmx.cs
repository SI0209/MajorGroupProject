using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Web.Services;

public class ChatbotController : WebService
{
    private static readonly Dictionary<string, List<KeyValuePair<string, string>>> FaqData =
        new Dictionary<string, List<KeyValuePair<string, string>>>()
        {
            {
                "Booking", new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>(
                        "How do I book a driving lesson?",
                        "You can book lessons through our website by first logging in with your email and password or registering an account. Select <b>BOOK ONLINE</b> and then choose your preferred date, time, instructor, and licence code."
                    ),
                    new KeyValuePair<string, string>(
                        "Can I reschedule a lesson?",
                        "Yes! You can reschedule up to <b>24 hours</b> before your lesson by logging into your account or contacting us."
                    )
                }
            },
            {
                "Pricing", new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>(
                        "How much does a driving lesson cost?",
                        "Code 8: <b>R200</b> per lesson.<br>Code 10: <b>R350</b> per lesson."
                    )
                }
            },
            {
                "Instructors", new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>(
                    "Who are your instructors?",
                    "All our instructors are <b>certified and experienced</b>."
                ),
                new KeyValuePair<string, string>(
                    "Can I choose my instructor?",
                    "Yes! When booking online, you can select your preferred instructor (if available)."
                )
            }
        },
        {
            "Driving Test", new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>(
                    "Do you provide test preparation?",
                    "Yes, we offer driving test preparation lessons tailored to your local licensing requirements."
                ),
                new KeyValuePair<string, string>(
                    "Can you help me book my driving test?",
                    "We can guide you on how to book your test and can also book with the local licensing authority for you if needed."
                )
            }
        },
        {
            "General", new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>(
                    "What are your operating hours?",
                    "Mon–Sat: <b>11:00–17:00</b><br>Sundays & Public Holidays: Closed"
                ),
                new KeyValuePair<string, string>(
                    "How can I contact the driving school?",
                    "Phone: <b>084 678 6530</b><br>Email: <b>arafismail075@gmail.com</b>"
                )
            }
        }
    };

    [WebMethod]
    public string GetFaq()
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        return js.Serialize(FaqData);
    }
}
