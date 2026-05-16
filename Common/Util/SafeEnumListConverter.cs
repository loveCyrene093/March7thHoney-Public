using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace March7thHoney.Util;

public class SafeEnumListConverter<TEnum> : JsonConverter<List<TEnum>> where TEnum : struct, Enum
{
	public override List<TEnum>? ReadJson(JsonReader reader, Type objectType, List<TEnum>? existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		List<TEnum> list = existingValue ?? new List<TEnum>();
		if (reader.TokenType == JsonToken.Null)
		{
			return list;
		}
		JToken jToken;
		try
		{
			jToken = JToken.Load(reader);
		}
		catch
		{
			return list;
		}
		if (jToken.Type != JTokenType.Array)
		{
			return list;
		}
		foreach (JToken item in jToken.Children())
		{
			switch (item.Type)
			{
			case JTokenType.Integer:
				list.Add((TEnum)Enum.ToObject(typeof(TEnum), item.Value<int>()));
				break;
			case JTokenType.String:
			{
				string value = item.Value<string>()?.Trim();
				if (!string.IsNullOrEmpty(value) && Enum.TryParse<TEnum>(value, ignoreCase: true, out var result))
				{
					list.Add(result);
				}
				break;
			}
			}
		}
		return list;
	}

	public override void WriteJson(JsonWriter writer, List<TEnum>? value, JsonSerializer serializer)
	{
		serializer.Serialize(writer, value ?? new List<TEnum>());
	}
}
