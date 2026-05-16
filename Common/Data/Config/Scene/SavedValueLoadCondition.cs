using System;
using System.Collections.Generic;
using March7thHoney.Enums;
using March7thHoney.Enums.Task;
using March7thHoney.Util;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace March7thHoney.Data.Config.Scene;

public class SavedValueLoadCondition
{
	public List<SavedValueCondition> Conditions { get; set; } = new List<SavedValueCondition>();

	[JsonConverter(typeof(StringEnumConverter))]
	public OperationEnum Operation { get; set; }

	public bool IsTrue(Dictionary<string, int> savedValue, bool defaultResult = true)
	{
		if (Conditions.Count == 0)
		{
			return defaultResult;
		}
		List<Func<bool>> list = new List<Func<bool>>();
		foreach (SavedValueCondition condition2 in Conditions)
		{
			SavedValueCondition condition = condition2;
			int status = savedValue.GetValueOrDefault(condition.SavedValueName, 0);
			if (condition.Operation != CompareTypeEnum.Unknow)
			{
				list.Add(CheckFunc);
			}
			bool CheckFunc()
			{
				return UtilTools.CompareNumberByOperationEnum(status, condition.Value, condition.Operation);
			}
		}
		switch (Operation)
		{
		case OperationEnum.And:
			if (!UtilTools.CheckAnd(list, defaultResult))
			{
				break;
			}
			goto IL_00b5;
		case OperationEnum.Or:
			if (!UtilTools.CheckOr(list, defaultResult))
			{
				break;
			}
			goto IL_00b5;
		case OperationEnum.Not:
			{
				return !UtilTools.CheckOr(list, defaultResult);
			}
			IL_00b5:
			return true;
		}
		return defaultResult;
	}
}
