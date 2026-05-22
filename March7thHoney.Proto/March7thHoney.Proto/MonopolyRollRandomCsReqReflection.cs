using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyRollRandomCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyRollRandomCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1Nb25vcG9seVJvbGxSYW5kb21Dc1JlcS5wcm90byIrChdNb25vcG9seVJv" + "bGxSYW5kb21Dc1JlcRIQCghldmVudF9pZBgMIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyRollRandomCsReq), MonopolyRollRandomCsReq.Parser, new string[1] { "EventId" }, null, null, null, null)
		}));
	}
}
