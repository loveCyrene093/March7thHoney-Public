using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelEndRoundShopStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelEndRoundShopStageScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CidDaGltZXJhRHVlbEVuZFJvdW5kU2hvcFN0YWdlU2NSc3AucHJvdG8aEURE";
		buffer[1] = "Sk9FSUJPRUxILnByb3RvIlcKIUNoaW1lcmFEdWVsRW5kUm91bmRTaG9wU3Rh";
		buffer[2] = "Z2VTY1JzcBIhCgtPSUFQSEJCRFBITBgGIAEoCzIMLkRESk9FSUJPRUxIEg8K";
		buffer[3] = "B3JldGNvZGUYCCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { DDJOEIBOELHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelEndRoundShopStageScRsp), ChimeraDuelEndRoundShopStageScRsp.Parser, new string[2] { "OIAPHBBDPHL", "Retcode" }, null, null, null, null)
		}));
	}
}
