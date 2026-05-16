using March7thHoney.Enums.Mission;

namespace March7thHoney.Database.Scene;

public class HeartDialInfo
{
	public int ScriptId { get; set; }

	public HeartDialEmoTypeEnum EmoType { get; set; }

	public HeartDialStepTypeEnum StepType { get; set; } = HeartDialStepTypeEnum.Normal;
}
