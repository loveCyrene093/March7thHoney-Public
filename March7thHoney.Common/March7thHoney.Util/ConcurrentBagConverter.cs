using System;
using System.Collections.Concurrent;
using Newtonsoft.Json;

namespace March7thHoney.Util;

public class ConcurrentBagConverter<T> : JsonConverter<ConcurrentBag<T>>
{
	public override void WriteJson(JsonWriter writer, ConcurrentBag<T>? value, JsonSerializer serializer)
	{
		if (value == null)
		{
			writer.WriteNull();
		}
		else
		{
			serializer.Serialize(writer, value.ToArray());
		}
	}

	public override ConcurrentBag<T>? ReadJson(JsonReader reader, Type objectType, ConcurrentBag<T>? existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		if (reader.TokenType == JsonToken.Null)
		{
			return null;
		}
		T[] array = serializer.Deserialize<T[]>(reader);
		if (array == null)
		{
			return new ConcurrentBag<T>();
		}
		return new ConcurrentBag<T>(array);
	}
}
