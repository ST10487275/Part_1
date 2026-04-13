using System;
using System.Collections.Generic;

namespace Part_1
{
    public static class ResponseLogic
    {
        private static Dictionary<string, string> responses = new Dictionary<string, string>()
        {
            //General questions
            { "how are you", "I'm doing great! I'm here to help you stay safe online." },
            { "purpose", "My purpose is to teach you about cybersecurity and how to stay safe online." },
            { "what can i ask", "You can ask me about password safety, phishing attacks, and safe browsing." },
            { "hello", "Hi there! Ask me about cybersecurity topics like passwords or phishing." },

            //Cybersecurity topics
            { "password", "Use strong passwords with uppercase, lowercase, numbers, and symbols. Avoid using personal info and never reuse passwords." },
            { "phishing", "Phishing is when attackers trick you into giving personal information through fake emails or websites. Always verify before clicking links." },
            { "safe browsing", "Always check for HTTPS in the URL and avoid suspicious websites or downloads." },
            { "safe", "Avoid unknown links and always verify websites before entering your information." },

            //Responses
            { "thank", "You're welcome! Stay safe online" },
            { "bye", "Goodbye! Stay secure" }
        };

        public static string GetResponse(string input)
        {
            foreach (var item in responses)
            {
                if (input.Contains(item.Key))
                {
                    return item.Value;
                }
            }

            //Fallback
            return "I didn’t quite understand that. Could you rephrase? Try asking about passwords, phishing, or safe browsing.";
        }
    }
}