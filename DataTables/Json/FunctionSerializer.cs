using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTables.Json
{
    // Solution adapted from https://stackoverflow.com/a/37578799
    public class FunctionSerializer : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(string));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            string valueAsString = value as string;

            if (!string.IsNullOrWhiteSpace(valueAsString))
                writer.WriteRawValue(valueAsString);
        }
    }
}
