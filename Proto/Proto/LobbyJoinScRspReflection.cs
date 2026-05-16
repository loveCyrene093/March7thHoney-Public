using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyJoinScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyJoinScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChRMb2JieUpvaW5TY1JzcC5wcm90bxoRQURITkpBRElKQUMucHJvdG8aE0Zp";
		buffer[1] = "Z2h0R2FtZU1vZGUucHJvdG8aEVBCSUNKQ1BETEdELnByb3RvIrIBCg5Mb2Ji";
		buffer[2] = "eUpvaW5TY1JzcBIhCgtCSUVCRkhFQ0VQTRgEIAMoCzIMLkFESE5KQURJSkFD";
		buffer[3] = "EiMKC1BMT0JNQkZQTkZLGAUgASgOMg4uRmlnaHRHYW1lTW9kZRIPCgdyb29t";
		buffer[4] = "X2lkGAYgASgEEhMKC0NIRU9ETUtBSEpNGAcgASgNEg8KB3JldGNvZGUYCCAB";
		buffer[5] = "KA0SIQoLUE9GT0NNSUhKSUEYDiABKAsyDC5QQklDSkNQRExHREIWqgITTWFy";
		buffer[6] = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			ADHNJADIJACReflection.Descriptor,
			FightGameModeReflection.Descriptor,
			PBICJCPDLGDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LobbyJoinScRsp), LobbyJoinScRsp.Parser, new string[6] { "BIEBFHECEPM", "PLOBMBFPNFK", "RoomId", "CHEODMKAHJM", "Retcode", "POFOCMIHJIA" }, null, null, null, null)
		}));
	}
}
