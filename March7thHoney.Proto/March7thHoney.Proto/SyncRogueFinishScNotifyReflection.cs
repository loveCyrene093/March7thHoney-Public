using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncRogueFinishScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncRogueFinishScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1TeW5jUm9ndWVGaW5pc2hTY05vdGlmeS5wcm90bxoRSk1JSUZPTUZPR08u" + "cHJvdG8iPAoXU3luY1JvZ3VlRmluaXNoU2NOb3RpZnkSIQoLZmluaXNoX2lu" + "Zm8YDCABKAsyDC5KTUlJRk9NRk9HT0IWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[1] { JMIIFOMFOGOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueFinishScNotify), SyncRogueFinishScNotify.Parser, new string[1] { "FinishInfo" }, null, null, null, null)
		}));
	}
}
