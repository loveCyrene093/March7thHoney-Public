using System;
using Newtonsoft.Json;

namespace March7thHoney.Util;

public class SafeStringEnumConverter<TEnum> : JsonConverter<TEnum> where TEnum : struct, Enum
{
	public override TEnum ReadJson(JsonReader reader, Type objectType, TEnum existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		if (reader.TokenType == JsonToken.Null)
		{
			return default(TEnum);
		}
		if (reader.TokenType == JsonToken.Integer)
		{
			int value = Convert.ToInt32(reader.Value);
			return (TEnum)Enum.ToObject(typeof(TEnum), value);
		}
		if (reader.TokenType == JsonToken.String)
		{
			string value2 = (reader.Value as string)?.Trim();
			if (string.IsNullOrEmpty(value2))
			{
				return default(TEnum);
			}
			if (Enum.TryParse<TEnum>(value2, ignoreCase: true, out var result))
			{
				return result;
			}
			return default(TEnum);
		}
		return default(TEnum);
	}

	public override void WriteJson(JsonWriter writer, TEnum value, JsonSerializer serializer)
	{
		writer.WriteValue(value.ToString());
	}
}
