using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MatchThreeV2ScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MatchThreeV2ScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpNYXRjaFRocmVlVjJTY05vdGlmeS5wcm90bxoRTk9KTFBNTEFMUEkucHJv" + "dG8iOQoUTWF0Y2hUaHJlZVYyU2NOb3RpZnkSIQoLS0pIR0dQRU1QSE0YBiAB" + "KAsyDC5OT0pMUE1MQUxQSUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[1] { NOJLPMLALPIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MatchThreeV2ScNotify), MatchThreeV2ScNotify.Parser, new string[1] { "KJHGGPEMPHM" }, null, null, null, null)
		}));
	}
}
