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
		buffer[0] = "ChdMb2JieUdldEluZm9TY1JzcC5wcm90bxoRQURITkpBRElKQUMucHJvdG8a";
		buffer[1] = "E0ZpZ2h0R2FtZU1vZGUucHJvdG8aEVBCSUNKQ1BETEdELnByb3RvIsoBChFM";
		buffer[2] = "b2JieUdldEluZm9TY1JzcBIPCgdyb29tX2lkGAIgASgEEhMKC0NIRU9ETUtB";
		buffer[3] = "SEpNGAYgASgNEiEKC0JJRUJGSEVDRVBNGAggAygLMgwuQURITkpBRElKQUMS";
		buffer[4] = "DwoHcmV0Y29kZRgJIAEoDRIhCgtQT0ZPQ01JSEpJQRgLIAEoCzIMLlBCSUNK";
		buffer[5] = "Q1BETEdEEhMKC0VJRkZETk5CR01DGA0gASgEEiMKC1BMT0JNQkZQTkZLGA4g";
		buffer[6] = "ASgOMg4uRmlnaHRHYW1lTW9kZUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[7] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
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
