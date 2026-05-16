using System;
using System.Collections.Generic;
using System.Globalization;
using March7thHoney.Enums.Task;

namespace March7thHoney.Util;

public static class UtilTools
{
	public static string GetCurrentLanguage()
	{
		return CultureInfo.CurrentUICulture.Name switch
		{
			"zh-CN" => "CHS", 
			"zh-TW" => "CHT", 
			"ja-JP" => "JP", 
			_ => "EN", 
		};
	}

	public static bool CheckAnd(List<Func<bool>> actions, bool defaultValue = true)
	{
		if (actions.Count == 0)
		{
			return defaultValue;
		}
		foreach (Func<bool> action in actions)
		{
			try
			{
				if (!action())
				{
					return false;
				}
			}
			catch
			{
			}
		}
		return true;
	}

	public static bool CheckOr(List<Func<bool>> actions, bool defaultValue = false)
	{
		if (actions.Count == 0)
		{
			return defaultValue;
		}
		foreach (Func<bool> action in actions)
		{
			try
			{
				if (action())
				{
					return true;
				}
			}
			catch
			{
			}
		}
		return false;
	}

	public static bool CompareNumberByOperationEnum(int left, int right, CompareTypeEnum operation)
	{
		return operation switch
		{
			CompareTypeEnum.Greater => left > right, 
			CompareTypeEnum.GreaterEqual => left >= right, 
			CompareTypeEnum.NotEqual => left != right, 
			CompareTypeEnum.Equal => left == right, 
			CompareTypeEnum.LessEqual => left <= right, 
			CompareTypeEnum.Less => left < right, 
			_ => false, 
		};
	}
}
