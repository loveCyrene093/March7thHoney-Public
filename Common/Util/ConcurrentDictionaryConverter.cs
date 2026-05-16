using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace March7thHoney.Util;

public class ConcurrentDictionaryConverter<TKey, TValue> : JsonConverter<ConcurrentDictionary<TKey, TValue>> where TKey : notnull
{
	public override void WriteJson(JsonWriter writer, ConcurrentDictionary<TKey, TValue>? value, JsonSerializer serializer)
	{
		if (value == null)
		{
			writer.WriteNull();
			return;
		}
		serializer.Serialize(writer, value.ToDictionary<KeyValuePair<TKey, TValue>, TKey, TValue>((KeyValuePair<TKey, TValue> kvp) => kvp.Key, (KeyValuePair<TKey, TValue> kvp) => kvp.Value));
	}

	public override ConcurrentDictionary<TKey, TValue>? ReadJson(JsonReader reader, Type objectType, ConcurrentDictionary<TKey, TValue>? existingValue, bool hasExistingValue, JsonSerializer serializer)
	{
		if (reader.TokenType == JsonToken.Null)
		{
			return null;
		}
		Dictionary<TKey, TValue> dictionary = serializer.Deserialize<Dictionary<TKey, TValue>>(reader);
		if (dictionary == null)
		{
			return new ConcurrentDictionary<TKey, TValue>();
		}
		return new ConcurrentDictionary<TKey, TValue>(dictionary);
	}
}
