using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyKickOutCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyKickOutCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdMb2JieUtpY2tPdXRDc1JlcS5wcm90byIgChFMb2JieUtpY2tPdXRDc1Jl" + "cRILCgN1aWQYBSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LobbyKickOutCsReq), LobbyKickOutCsReq.Parser, new string[1] { "Uid" }, null, null, null, null)
		}));
	}
}
