using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Globalization;

namespace Common.Extensions
{
    public static class Extentsion
    {
        public static String ToJson(this Object obj)
        {
            return  JsonConvert.SerializeObject(obj);
        }

        public static String ToJson(this Object obj, params JsonConverter[] converters)
        {
            return JsonConvert.SerializeObject(obj, converters);
        }

        public static T Parse<T>(this Object obj, string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static T Parse<T>(this Object obj, string json, params JsonConverter[] converters)
        {
            return JsonConvert.DeserializeObject<T>(json, converters);
        }
    }

    public class DateTimeJsonConverter : JsonConverter
    {
        private string datetimeformat;

        public DateTimeJsonConverter(string datetimeformat)
        {
            this.datetimeformat = datetimeformat;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.Equals(typeof(DateTime));
        }

        public override object ReadJson(JsonReader reader, Type objectType, 
            object existingValue, JsonSerializer serializer)
        {
            String value = (String)reader.Value;
            return DateTime.ParseExact(value, datetimeformat, CultureInfo.InvariantCulture);
        }

        public override void WriteJson(JsonWriter writer, object value, 
            JsonSerializer serializer)
        {
            writer.WriteValue(((DateTime)value).ToString(datetimeformat));
        }
    }
}
