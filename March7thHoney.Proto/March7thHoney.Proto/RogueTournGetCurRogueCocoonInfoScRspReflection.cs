using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournGetCurRogueCocoonInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournGetCurRogueCocoonInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CipSb2d1ZVRvdXJuR2V0Q3VyUm9ndWVDb2Nvb25JbmZvU2NSc3AucHJvdG8i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "igEKJFJvZ3VlVG91cm5HZXRDdXJSb2d1ZUNvY29vbkluZm9TY1JzcBINCgVD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "b3VudBgDIAEoDRITCgtMSlBMSUhFUEdIQRgEIAEoDRIYChBkaWZmaWN1bHR5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "X2xldmVsGAUgASgNEhMKC0pPTUhFSUhMTERNGAkgASgNEg8KB3JldGNvZGUY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "CiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournGetCurRogueCocoonInfoScRsp), RogueTournGetCurRogueCocoonInfoScRsp.Parser, new string[5] { "Count", "LJPLIHEPGHA", "DifficultyLevel", "JOMHEIHLLDM", "Retcode" }, null, null, null, null)
		}));
	}
}
