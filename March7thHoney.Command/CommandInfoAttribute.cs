using System;

namespace March7thHoney.Command;

[AttributeUsage(AttributeTargets.Class)]
public class CommandInfoAttribute : Attribute
{
	public string Name { get; }

	public string Description { get; }

	public string Usage { get; }

	public string Keyword { get; }

	public string Permission { get; }

	public string[] Alias { get; }

	public CommandInfoAttribute(string name, string description, string usage, string keyword = "", string permission = "")
	{
		Name = name;
		Description = description;
		Usage = usage;
		Keyword = keyword;
		Permission = permission;
		Alias = Array.Empty<string>();
		base._002Ector();
	}

	public CommandInfoAttribute(string name, string description, string usage, string[] alias, string keyword = "", string permission = "")
		: this(name, description, usage, keyword, permission)
	{
		Alias = alias;
	}
}
