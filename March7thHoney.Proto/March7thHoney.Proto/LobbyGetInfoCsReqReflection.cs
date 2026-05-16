using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyGetInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyGetInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdMb2JieUdldEluZm9Dc1JlcS5wcm90byITChFMb2JieUdldEluZm9Dc1Jl" + "cUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LobbyGetInfoCsReq), LobbyGetInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
