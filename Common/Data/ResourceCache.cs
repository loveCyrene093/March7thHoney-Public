using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Internationalization;
using March7thHoney.Util;
using Newtonsoft.Json;

namespace March7thHoney.Data;

public class ResourceCache
{
	public static readonly JsonSerializerSettings Serializer = new JsonSerializerSettings
	{
		ContractResolver = new IgnoreJsonIgnoreContractResolver(),
		TypeNameHandling = TypeNameHandling.Auto,
		Converters = 
		{
			(JsonConverter)new ConcurrentBagConverter<PropInfo>(),
			(JsonConverter)new ConcurrentDictionaryConverter<string, FloorInfo>()
		}
	};

	public static Logger Logger { get; } = new Logger("ResCache");

	public static string CachePath { get; } = ConfigManager.Config.Path.ConfigPath + "/Resource.cache";

	public static bool IsComplete { get; set; } = true;

	public static Task SaveCache()
	{
		return Task.Run(delegate
		{
			ResourceCacheData value = new ResourceCacheData
			{
				GameDataValues = (from p in typeof(GameData).GetProperties(BindingFlags.Static | BindingFlags.Public)
					where p.GetValue(null) != null
					select p).ToDictionary((PropertyInfo p) => p.Name, (PropertyInfo p) => CompressionHelper.Compress(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(p.GetValue(null), Serializer))))
			};
			File.WriteAllText(CachePath, JsonConvert.SerializeObject(value));
			Logger.Info(I18NManager.Translate("Server.ServerInfo.GeneratedItem", I18NManager.Translate("Word.Cache")));
		});
	}

	public static bool LoadCache()
	{
		byte[] array = new byte[new FileInfo(CachePath).Length];
		MemoryMappedFile.CreateFromFile(CachePath, FileMode.Open).CreateViewAccessor().ReadArray(0L, array, 0, array.Length);
		ResourceCacheData cacheData = JsonConvert.DeserializeObject<ResourceCacheData>(Encoding.UTF8.GetString(array));
		if (cacheData == null)
		{
			return false;
		}
		Parallel.ForEach(typeof(GameData).GetProperties(BindingFlags.Static | BindingFlags.Public), delegate(PropertyInfo prop)
		{
			try
			{
				if (ConfigManager.Config.ServerOption.LogOption.LogResourceCacheLoading)
				{
					Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadingItem", prop.DeclaringType?.Name + "." + prop.Name));
				}
				if (cacheData.GameDataValues.TryGetValue(prop.Name, out byte[] value))
				{
					object deserialized = JsonConvert.DeserializeObject(Encoding.UTF8.GetString(CompressionHelper.Decompress(value)), prop.PropertyType, Serializer);
					ApplyCachedValue(prop, deserialized);
				}
			}
			catch (Exception ex)
			{
				Logger.Error(I18NManager.Translate("Server.ServerInfo.FailedToLoadItem", prop.DeclaringType?.Name + "." + prop.Name));
				Logger.Error(ex.Message);
			}
		});
		Logger.Info(I18NManager.Translate("Server.ServerInfo.LoadedItem", I18NManager.Translate("Word.Cache")));
		return true;
	}

	private static void ApplyCachedValue(PropertyInfo prop, object? deserialized)
	{
		if (prop.CanWrite)
		{
			prop.SetValue(null, deserialized);
			return;
		}
		object value = prop.GetValue(null);
		if (value == null || deserialized == null)
		{
			return;
		}
		if (value is IDictionary dictionary && deserialized is IDictionary dictionary2)
		{
			dictionary.Clear();
			{
				foreach (DictionaryEntry item in dictionary2)
				{
					dictionary[item.Key] = item.Value;
				}
				return;
			}
		}
		if (!(value is IList list) || !(deserialized is IList list2))
		{
			return;
		}
		list.Clear();
		foreach (object item2 in list2)
		{
			list.Add(item2);
		}
	}

	public static void ClearGameData()
	{
		PropertyInfo[] properties = typeof(GameData).GetProperties(BindingFlags.Static | BindingFlags.Public);
		foreach (PropertyInfo obj in properties)
		{
			Type propertyType = obj.PropertyType;
			object value = ((propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(Dictionary<, >)) ? Activator.CreateInstance(propertyType) : ((propertyType.IsGenericType && propertyType.GetGenericTypeDefinition() == typeof(List<>)) ? Activator.CreateInstance(propertyType) : (propertyType.IsClass ? Activator.CreateInstance(propertyType) : null)));
			obj.SetValue(null, value);
		}
	}
}
