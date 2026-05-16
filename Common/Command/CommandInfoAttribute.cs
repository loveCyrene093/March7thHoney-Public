using System;

namespace March7thHoney.Command;

[AttributeUsage(AttributeTargets.Class)]
public class CommandInfoAttribute(string name, string description, string usage, string keyword = "", string permission = "") : Attribute
{
	public string Name { get; } = name;

	public string Description { get; } = description;

	public string Usage { get; } = usage;

	public string Keyword { get; } = keyword;

	public string Permission { get; } = permission;

	public string[] Alias { get; } = Array.Empty<string>();

	public CommandInfoAttribute(string name, string description, string usage, string[] alias, string keyword = "", string permission = "")
		: this(name, description, usage, keyword, permission)
	{
		Alias = alias;
	}
}
