using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using March7thHoney.Enums.Language;
using March7thHoney.Internationalization.Message;
using March7thHoney.Util;

namespace March7thHoney.Internationalization;

public static class I18NManager
{
	public static Logger Logger = new Logger("I18nManager");

	public static object Language { get; set; } = new LanguageEN();

	public static Dictionary<string, Dictionary<ProgramLanguageTypeEnum, object>> PluginLanguages { get; } = new Dictionary<string, Dictionary<ProgramLanguageTypeEnum, object>>();

	public static void LoadLanguage()
	{
		Type type = Type.GetType("March7thHoney.Internationalization.Message.Language" + ConfigManager.Config.ServerOption.Language);
		if (type == null)
		{
			Logger.Warn("Language not found, fallback to EN");
			type = Type.GetType("March7thHoney.Internationalization.Message.LanguageEN");
		}
		Language = Activator.CreateInstance(type) ?? throw new Exception("Language not found");
		Logger.Info(Translate("Server.ServerInfo.LoadedItem", Translate("Word.Language")));
	}

	public static void LoadPluginLanguage(Dictionary<string, List<Type>> pluginAssemblies)
	{
		foreach (KeyValuePair<string, List<Type>> pluginAssembly in pluginAssemblies)
		{
			pluginAssembly.Deconstruct(out var key, out var value);
			string key2 = key;
			List<Type> list = value.FindAll((Type x) => x.GetCustomAttribute<PluginLanguageAttribute>() != null);
			if (list.Count == 0)
			{
				continue;
			}
			PluginLanguages.Add(key2, new Dictionary<ProgramLanguageTypeEnum, object>());
			foreach (Type item in list)
			{
				PluginLanguageAttribute customAttribute = item.GetCustomAttribute<PluginLanguageAttribute>();
				if (customAttribute != null)
				{
					object obj = Activator.CreateInstance(item);
					if (obj != null)
					{
						PluginLanguages[key2].Add(customAttribute.LanguageType, obj);
					}
				}
			}
		}
	}

	public static string Translate(string key, params string[] args)
	{
		List<object> list = (from pluginLang in PluginLanguages.Values
			from o in pluginLang
			where o.Key == Enum.Parse<ProgramLanguageTypeEnum>(ConfigManager.Config.ServerOption.Language)
			select o.Value).ToList();
		list.Add(Language);
		string seed = list.Select((object lang) => GetNestedPropertyValue(lang, key)).OfType<string>().FirstOrDefault() ?? key;
		int index = 0;
		return args.Aggregate(seed, (string current, string arg) => current.Replace("{" + index++ + "}", arg));
	}

	public static string TranslateAsCertainLang(string langStr, string key, params string[] args)
	{
		object obj = Activator.CreateInstance(Type.GetType("March7thHoney.Internationalization.Message.Language" + langStr) ?? Type.GetType("March7thHoney.Internationalization.Message.LanguageEN")) ?? throw new Exception("Language not found");
		int num = 1;
		List<object> list = new List<object>(num);
		CollectionsMarshal.SetCount(list, num);
		CollectionsMarshal.AsSpan(list)[0] = obj;
		string seed = list.Select((object lang) => GetNestedPropertyValue(lang, key)).OfType<string>().FirstOrDefault() ?? key;
		int index = 0;
		return args.Aggregate(seed, (string current, string arg) => current.Replace("{" + index++ + "}", arg));
	}

	public static string? GetNestedPropertyValue(object? obj, string propertyName)
	{
		string[] array = propertyName.Split('.');
		foreach (string name in array)
		{
			if (obj == null)
			{
				return null;
			}
			PropertyInfo property = obj.GetType().GetProperty(name);
			if (property == null)
			{
				return null;
			}
			obj = property.GetValue(obj, null);
		}
		return (string)obj;
	}
}
