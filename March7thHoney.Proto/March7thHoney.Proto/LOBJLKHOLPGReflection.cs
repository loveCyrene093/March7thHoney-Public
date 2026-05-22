using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LOBJLKHOLPGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LOBJLKHOLPGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMT0JKTEtIT0xQRy5wcm90bxoRUEtKR0dBUExPTkMucHJvdG8iXwoLTE9C" + "SkxLSE9MUEcSIQoLYXZhdGFyX2xpc3QYASADKAsyDC5QS0pHR0FQTE9OQxIc" + "ChRmaW5pc2hlZF90YXJnZXRfbGlzdBgJIAMoDRIPCgdwZWFrX2lkGAsgASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { PKJGGAPLONCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LOBJLKHOLPG), LOBJLKHOLPG.Parser, new string[3] { "AvatarList", "FinishedTargetList", "PeakId" }, null, null, null, null)
		}));
	}
}
