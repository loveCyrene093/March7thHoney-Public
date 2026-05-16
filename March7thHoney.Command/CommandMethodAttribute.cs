using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace March7thHoney.Command;

[AttributeUsage(AttributeTargets.Method)]
public class CommandMethodAttribute : Attribute
{
	public List<CommandCondition> Conditions { get; }

	public CommandMethodAttribute(CommandCondition conditions)
	{
		int num = 1;
		List<CommandCondition> list = new List<CommandCondition>(num);
		CollectionsMarshal.SetCount(list, num);
		CollectionsMarshal.AsSpan(list)[0] = conditions;
		Conditions = list;
		base._002Ector();
	}

	public CommandMethodAttribute(string condition)
		: this(new CommandCondition())
	{
		int index = 0;
		string[] array = condition.Split(' ');
		foreach (string text in array)
		{
			if (int.TryParse(text, out var result))
			{
				Conditions[index].Index = result;
			}
			else
			{
				Conditions[index++].ShouldBe = text;
			}
		}
	}
}
