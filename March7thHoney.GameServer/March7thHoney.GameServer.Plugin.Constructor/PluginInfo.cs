using System;

namespace March7thHoney.GameServer.Plugin.Constructor;

[AttributeUsage(AttributeTargets.Class)]
public class PluginInfo : Attribute
{
	public string Name { get; }

	public string Description { get; }

	public string Version { get; }

	public PluginInfo(string name, string description, string version)
	{
		Name = name;
		Description = description;
		Version = version;
		base._002Ector();
	}
}
