using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum ChangeStoryLineAction
{
	[OriginalName("ChangeStoryLineAction_None")]
	None,
	[OriginalName("ChangeStoryLineAction_FinishAction")]
	FinishAction,
	[OriginalName("ChangeStoryLineAction_Client")]
	Client,
	[OriginalName("ChangeStoryLineAction_CustomOP")]
	CustomOp,
	[OriginalName("ChangeStoryLineAction_Raid")]
	Raid,
	[OriginalName("ChangeStoryLineAction_HKFKAFPAJCO")]
	Hkfkafpajco
}
