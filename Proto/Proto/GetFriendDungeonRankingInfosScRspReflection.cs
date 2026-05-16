using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendDungeonRankingInfosScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendDungeonRankingInfosScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CidHZXRGcmllbmREdW5nZW9uUmFua2luZ0luZm9zU2NSc3AucHJvdG8aEUNH";
		buffer[1] = "RkJERkhETkdPLnByb3RvImwKIUdldEZyaWVuZER1bmdlb25SYW5raW5nSW5m";
		buffer[2] = "b3NTY1JzcBIhCgtDUEJHTE5HT0NCQRgFIAMoCzIMLkNHRkJERkhETkdPEhMK";
		buffer[3] = "C0JJQlBFSk1MQ01GGAogASgNEg8KB3JldGNvZGUYDyABKA1CFqoCE01hcmNo";
		buffer[4] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { CGFBDFHDNGOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendDungeonRankingInfosScRsp), GetFriendDungeonRankingInfosScRsp.Parser, new string[3] { "CPBGLNGOCBA", "BIBPEJMLCMF", "Retcode" }, null, null, null, null)
		}));
	}
}
