using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace ASPNetCoreIntro.Extedions
{
    public static class SessionsExtedionsMethod
    {

        public static void SetObject(this ISession session, string key, object value)
        {
            string objectString = JsonConvert.SerializeObject(value);
            session.SetString(key, objectString);
        }

        public static T GetObject<T>(this ISession session,string key) where T:class
        {
            string objecString = session.GetString(key);
            if (string.IsNullOrEmpty(objecString))
            {
                return null;
            }
            else
            {
                T value = JsonConvert.DeserializeObject<T>(objecString);
                return value;
            }


        }
    }
}
