using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Custom;
using March7thHoney.Enums.Scene;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using Newtonsoft.Json.Linq;

namespace March7thHoney.GameServer.Game.Scene.Component;

public class RainbowSceneComponent : BaseSceneComponent
{
	public int CurTargetPuzzleGroupId { get; set; }

	public RainbowSceneComponent(SceneInstance scene)
		: base(scene)
	{
	}

	public override ValueTask Initialize()
	{
		CurTargetPuzzleGroupId = base.SceneInst.Player.SceneData.FloorTargetPuzzleGroupData.GetValueOrDefault(base.SceneInst.FloorId, 0);
		base.SceneInst.GroupPropertyUpdated += GroupPropertyUpdated;
		return ValueTask.CompletedTask;
	}

	private async ValueTask GroupPropertyUpdated(GroupPropertyRefreshData data)
	{
		Dictionary<string, Dictionary<int, RainbowGroupPropertyInfo>> valueOrDefault = GameData.SceneRainbowGroupPropertyData.FloorProperty.GetValueOrDefault(base.SceneInst.FloorId, new Dictionary<int, Dictionary<string, Dictionary<int, RainbowGroupPropertyInfo>>>()).GetValueOrDefault(data.GroupId);
		if (valueOrDefault != null)
		{
			RainbowGroupPropertyInfo targetActions = valueOrDefault.GetValueOrDefault(data.PropertyName)?.GetValueOrDefault(data.NewValue);
			if (targetActions != null)
			{
				await ExecuteRainbowActions(targetActions.PrivateActions);
				await ExecuteRainbowActions(targetActions.Actions);
			}
		}
	}

	private async ValueTask ExecuteRainbowActions(List<RainbowActionInfo> actions)
	{
		foreach (RainbowActionInfo action in actions)
		{
			switch (action.ActionType)
			{
			case SceneActionTypeEnum.SetGroupProperty:
				await SetGroupProperty(action.Params);
				break;
			case SceneActionTypeEnum.ChangeCurrentTargetPuzzle:
				ChangeCurrentTargetPuzzle(action.Params);
				break;
			case SceneActionTypeEnum.SetGroupPropertyByCopyAnother:
				await SetGroupPropertyByCopyAnother(action.Params);
				break;
			case SceneActionTypeEnum.PropertyValueEqual:
				await PropertyValueEqual(action.Params);
				break;
			case SceneActionTypeEnum.SetFloorSavedValue:
				await SetFloorSavedValue(action.Params);
				break;
			case SceneActionTypeEnum.CallCurrentTargetPuzzlePropertyAction:
				await CallCurrentTargetPuzzlePropertyAction(action.Params);
				break;
			case SceneActionTypeEnum.CallCurrentTargetPuzzlePropertyChanged:
				await CallCurrentTargetPuzzlePropertyChanged(action.Params);
				break;
			}
		}
	}

	private async ValueTask SetGroupProperty(Dictionary<string, object> param)
	{
		int num = (int)(long)(param.GetValueOrDefault("GroupId") ?? ((object)0));
		string text = (string)(param.GetValueOrDefault("PropertyName") ?? string.Empty);
		int value = (int)(long)(param.GetValueOrDefault("PropertyValue") ?? ((object)0));
		if (num != 0 && !string.IsNullOrEmpty(text))
		{
			await base.SceneInst.UpdateGroupProperty(num, text, value, callEvent: false);
		}
	}

	private void ChangeCurrentTargetPuzzle(Dictionary<string, object> param)
	{
		int num = (int)(long)(param.GetValueOrDefault("GroupId") ?? ((object)0));
		if (num != 0)
		{
			CurTargetPuzzleGroupId = num;
			base.SceneInst.Player.SceneData.FloorTargetPuzzleGroupData[base.SceneInst.FloorId] = num;
		}
	}

	private async ValueTask SetGroupPropertyByCopyAnother(Dictionary<string, object> param)
	{
		int num = (int)(long)(param.GetValueOrDefault("GroupId") ?? ((object)0));
		string text = (string)(param.GetValueOrDefault("PropertyName") ?? string.Empty);
		string text2 = (string)(param.GetValueOrDefault("PropertyCopyFromName") ?? string.Empty);
		if (num != 0 && !string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2))
		{
			int groupProperty = base.SceneInst.GetGroupProperty(num, text2);
			await base.SceneInst.UpdateGroupProperty(num, text, groupProperty, callEvent: false);
		}
	}

	private async ValueTask PropertyValueEqual(Dictionary<string, object> param)
	{
		int num = (int)(long)(param.GetValueOrDefault("GroupId") ?? ((object)0));
		string text = (string)(param.GetValueOrDefault("PropertyName") ?? string.Empty);
		int num2 = (int)(long)(param.GetValueOrDefault("PropertyValue") ?? ((object)0));
		JToken jToken = (JToken)(param.GetValueOrDefault("SuccActions") ?? JArray.Parse("[]"));
		if (num != 0 && !string.IsNullOrEmpty(text))
		{
			List<RainbowActionInfo> actions = jToken.ToObject<List<RainbowActionInfo>>() ?? new List<RainbowActionInfo>();
			if (base.SceneInst.GetGroupProperty(num, text) == num2)
			{
				await ExecuteRainbowActions(actions);
			}
		}
	}

	private async ValueTask SetFloorSavedValue(Dictionary<string, object> param)
	{
		string text = (string)(param.GetValueOrDefault("SavedValueName") ?? string.Empty);
		int value = (int)(long)(param.GetValueOrDefault("SavedValue") ?? ((object)0));
		if (!string.IsNullOrEmpty(text))
		{
			await base.SceneInst.UpdateFloorSavedValue(text, value);
		}
	}

	private async ValueTask CallCurrentTargetPuzzlePropertyAction(Dictionary<string, object> param)
	{
		string text = (string)(param.GetValueOrDefault("PropertyName") ?? string.Empty);
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		Dictionary<string, Dictionary<int, RainbowGroupPropertyInfo>> valueOrDefault = GameData.SceneRainbowGroupPropertyData.FloorProperty.GetValueOrDefault(base.SceneInst.FloorId, new Dictionary<int, Dictionary<string, Dictionary<int, RainbowGroupPropertyInfo>>>()).GetValueOrDefault(CurTargetPuzzleGroupId);
		if (valueOrDefault != null)
		{
			RainbowGroupPropertyInfo rainbowGroupPropertyInfo = valueOrDefault.GetValueOrDefault(text)?.GetValueOrDefault(base.SceneInst.GetGroupProperty(CurTargetPuzzleGroupId, text));
			if (rainbowGroupPropertyInfo != null)
			{
				await ExecuteRainbowActions(rainbowGroupPropertyInfo.Actions);
			}
		}
	}

	private async ValueTask CallCurrentTargetPuzzlePropertyChanged(Dictionary<string, object> param)
	{
		string text = (string)(param.GetValueOrDefault("PropertyName") ?? string.Empty);
		int key = (int)(long)(param.GetValueOrDefault("PropertyValue") ?? ((object)0));
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		Dictionary<string, Dictionary<int, RainbowGroupPropertyInfo>> valueOrDefault = GameData.SceneRainbowGroupPropertyData.FloorProperty.GetValueOrDefault(base.SceneInst.FloorId, new Dictionary<int, Dictionary<string, Dictionary<int, RainbowGroupPropertyInfo>>>()).GetValueOrDefault(CurTargetPuzzleGroupId);
		if (valueOrDefault != null)
		{
			RainbowGroupPropertyInfo rainbowGroupPropertyInfo = valueOrDefault.GetValueOrDefault(text)?.GetValueOrDefault(key);
			if (rainbowGroupPropertyInfo != null)
			{
				await ExecuteRainbowActions(rainbowGroupPropertyInfo.Actions);
			}
		}
	}
}
