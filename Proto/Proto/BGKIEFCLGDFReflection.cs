using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BGKIEFCLGDFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BGKIEFCLGDFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCR0tJRUZDTEdERi5wcm90bxoTRmlnaHRHYW1lTW9kZS5wcm90byJYCgtC" + "R0tJRUZDTEdERhIPCgdyb29tX2lkGAIgASgNEhMKC0FPTkdPRUFGS09DGAQg" + "ASgNEiMKC1BMT0JNQkZQTkZLGAYgASgOMg4uRmlnaHRHYW1lTW9kZUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { FightGameModeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BGKIEFCLGDF), BGKIEFCLGDF.Parser, new string[3] { "RoomId", "AONGOEAFKOC", "PLOBMBFPNFK" }, null, null, null, null)
		}));
	}
}
