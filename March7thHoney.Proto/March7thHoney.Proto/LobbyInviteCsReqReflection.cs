using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyInviteCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyInviteCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZMb2JieUludml0ZUNzUmVxLnByb3RvIiQKEExvYmJ5SW52aXRlQ3NSZXES" + "EAoIdWlkX2xpc3QYAyADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LobbyInviteCsReq), LobbyInviteCsReq.Parser, new string[1] { "UidList" }, null, null, null, null)
		}));
	}
}
