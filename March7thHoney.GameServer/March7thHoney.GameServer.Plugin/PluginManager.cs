using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using March7thHoney.GameServer.Plugin.Constructor;
using March7thHoney.Internationalization;
using March7thHoney.Util;
using McMaster.NETCore.Plugins;

namespace March7thHoney.GameServer.Plugin;

public class PluginManager
{
	private static readonly Logger Logger = new Logger("PluginManager");

	public static readonly Dictionary<IPlugin, PluginInfo> Plugins = new Dictionary<IPlugin, PluginInfo>();

	public static readonly Dictionary<IPlugin, List<Type>> PluginAssemblies = new Dictionary<IPlugin, List<Type>>();

	public static List<Type> GetPluginAssemblies()
	{
		List<Type> list = new List<Type>();
		foreach (IPlugin key in Plugins.Keys)
		{
			if (PluginAssemblies.TryGetValue(key, out List<Type> value))
			{
				list.AddRange(value);
			}
		}
		return list;
	}

	public static void LoadPlugins()
	{
		if (!Directory.Exists(ConfigManager.Config.Path.PluginPath))
		{
			Directory.CreateDirectory(ConfigManager.Config.Path.PluginPath);
		}
		string[] files = Directory.GetFiles(ConfigManager.Config.Path.PluginPath, "*.dll");
		AppDomain.CurrentDomain.AssemblyResolve += delegate(object? _, ResolveEventArgs args)
		{
			string path = new AssemblyName(args.Name).Name + ".dll";
			string text = Path.Combine(ConfigManager.Config.Path.PluginPath, path);
			return (!File.Exists(text)) ? null : Assembly.LoadFrom(text);
		};
		string[] array = files;
		for (int num = 0; num < array.Length; num++)
		{
			LoadPlugin(new FileInfo(array[num]).FullName);
		}
	}

	public static void LoadPlugin(string plugin)
	{
		try
		{
			Type[] types = new PluginLoader(new PluginConfig(plugin)
			{
				PreferSharedTypes = true,
				LoadInMemory = true
			}).LoadDefaultAssembly().GetTypes();
			Type[] array = types;
			foreach (Type type in array)
			{
				if (!typeof(IPlugin).IsAssignableFrom(type))
				{
					continue;
				}
				if (Activator.CreateInstance(type) is IPlugin plugin2)
				{
					PluginInfo pluginInfo = type.GetCustomAttribute<PluginInfo>();
					if (pluginInfo != null)
					{
						Logger.Info($"Loaded plugin {pluginInfo.Name} v{pluginInfo.Version}: {pluginInfo.Description}");
						if (Plugins.Values.Any((PluginInfo p) => p.Name == pluginInfo.Name))
						{
							Logger.Error("Failed to load plugin " + plugin + ": Plugin already loaded");
							continue;
						}
						Plugins.Add(plugin2, pluginInfo);
						if (!PluginAssemblies.TryGetValue(plugin2, out List<Type> value))
						{
							value = new List<Type>();
							PluginAssemblies[plugin2] = value;
						}
						value.AddRange(types);
						try
						{
							I18NManager.LoadPluginLanguage(new Dictionary<string, List<Type>> { { pluginInfo.Name, value } });
							plugin2.OnLoad();
						}
						catch (Exception ex)
						{
							Logger.Error("Failed to load plugin " + plugin + ": " + ex.Message);
							UnloadPlugin(plugin2);
						}
					}
					else
					{
						Logger.Info("Loaded plugin " + plugin + ": No plugin info");
					}
				}
				else
				{
					Logger.Error("Failed to load plugin " + plugin + ": Plugin instance is null");
				}
			}
		}
		catch (Exception ex2)
		{
			Logger.Error("Failed to load plugin " + plugin + ": " + ex2.Message);
		}
	}

	public static void UnloadPlugin(IPlugin plugin)
	{
		if (Plugins.TryGetValue(plugin, out PluginInfo value))
		{
			plugin.OnUnload();
			Plugins.Remove(plugin);
			PluginAssemblies.Remove(plugin);
			I18NManager.PluginLanguages.Remove(value.Name);
			Logger.Info("Unloaded plugin " + value.Name);
		}
	}

	public static void UnloadPlugins()
	{
		foreach (IPlugin key in Plugins.Keys)
		{
			UnloadPlugin(key);
		}
		Logger.Info(I18NManager.Translate("Server.ServerInfo.UnloadedItems", I18NManager.Translate("Word.Plugin")));
	}
}
