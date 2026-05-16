using System;
using March7thHoney.Util;
using Newtonsoft.Json;
using SqlSugar;

namespace March7thHoney.Database;

public class CustomSerializeService : ISerializeService
{
	private readonly JsonSerializerSettings _jsonSettings;

	public CustomSerializeService()
	{
		_jsonSettings = new JsonSerializerSettings
		{
			DefaultValueHandling = DefaultValueHandling.Ignore,
			ObjectCreationHandling = ObjectCreationHandling.Replace
		};
	}

	public string SerializeObject(object value)
	{
		return JsonConvert.SerializeObject(value, _jsonSettings);
	}

	public T DeserializeObject<T>(string value)
	{
		try
		{
			return JsonConvert.DeserializeObject<T>(value);
		}
		catch
		{
			try
			{
				Logger.GetByClassName().Warn("Error occured when load database, resetting the mistake value");
				return Activator.CreateInstance<T>();
			}
			catch
			{
				return default(T);
			}
		}
	}

	public string SugarSerializeObject(object value)
	{
		return JsonConvert.SerializeObject(value, _jsonSettings);
	}
}
