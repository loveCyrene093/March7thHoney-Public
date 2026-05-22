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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CidHZXRGcmllbmREdW5nZW9uUmFua2luZ0luZm9zU2NSc3AucHJvdG8aEUNH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RkJERkhETkdPLnByb3RvImwKIUdldEZyaWVuZER1bmdlb25SYW5raW5nSW5m";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "b3NTY1JzcBIhCgtDUEJHTE5HT0NCQRgFIAMoCzIMLkNHRkJERkhETkdPEhMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "C0JJQlBFSk1MQ01GGAogASgNEg8KB3JldGNvZGUYDyABKA1CFqoCE01hcmNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { CGFBDFHDNGOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendDungeonRankingInfosScRsp), GetFriendDungeonRankingInfosScRsp.Parser, new string[3] { "CPBGLNGOCBA", "BIBPEJMLCMF", "Retcode" }, null, null, null, null)
		}));
	}
}
