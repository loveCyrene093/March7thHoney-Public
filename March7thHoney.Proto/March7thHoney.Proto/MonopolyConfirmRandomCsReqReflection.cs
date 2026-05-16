using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyConfirmRandomCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyConfirmRandomCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBNb25vcG9seUNvbmZpcm1SYW5kb21Dc1JlcS5wcm90byIuChpNb25vcG9s" + "eUNvbmZpcm1SYW5kb21Dc1JlcRIQCghldmVudF9pZBgBIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyConfirmRandomCsReq), MonopolyConfirmRandomCsReq.Parser, new string[1] { "EventId" }, null, null, null, null)
		}));
	}
}
