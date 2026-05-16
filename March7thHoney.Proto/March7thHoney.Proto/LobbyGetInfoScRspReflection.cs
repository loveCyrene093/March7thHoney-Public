using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyGetInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyGetInfoScRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChdMb2JieUdldEluZm9TY1JzcC5wcm90bxoRQURITkpBRElKQUMucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "E0ZpZ2h0R2FtZU1vZGUucHJvdG8aEVBCSUNKQ1BETEdELnByb3RvIsoBChFM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "b2JieUdldEluZm9TY1JzcBIPCgdyb29tX2lkGAIgASgEEhMKC0NIRU9ETUtB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "SEpNGAYgASgNEiEKC0JJRUJGSEVDRVBNGAggAygLMgwuQURITkpBRElKQUMS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "DwoHcmV0Y29kZRgJIAEoDRIhCgtQT0ZPQ01JSEpJQRgLIAEoCzIMLlBCSUNK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "Q1BETEdEEhMKC0VJRkZETk5CR01DGA0gASgEEiMKC1BMT0JNQkZQTkZLGA4g";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "ASgOMg4uRmlnaHRHYW1lTW9kZUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[3]
		{
			ADHNJADIJACReflection.Descriptor,
			FightGameModeReflection.Descriptor,
			PBICJCPDLGDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LobbyGetInfoScRsp), LobbyGetInfoScRsp.Parser, new string[7] { "RoomId", "CHEODMKAHJM", "BIEBFHECEPM", "Retcode", "POFOCMIHJIA", "EIFFDNNBGMC", "PLOBMBFPNFK" }, null, null, null, null)
		}));
	}
}
