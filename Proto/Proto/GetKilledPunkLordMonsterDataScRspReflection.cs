using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetKilledPunkLordMonsterDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetKilledPunkLordMonsterDataScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CidHZXRLaWxsZWRQdW5rTG9yZE1vbnN0ZXJEYXRhU2NSc3AucHJvdG8aEUpM";
		buffer[1] = "TElERElCT0hJLnByb3RvGhFMTUlJTkhIS0xOTC5wcm90byJ6CiFHZXRLaWxs";
		buffer[2] = "ZWRQdW5rTG9yZE1vbnN0ZXJEYXRhU2NSc3ASIQoLTEtGS0tHTkFDTlAYBiAD";
		buffer[3] = "KAsyDC5KTExJRERJQk9ISRIhCgtHUEJLSUhBTElOQhgIIAMoCzIMLkxNSUlO";
		buffer[4] = "SEhLTE5MEg8KB3JldGNvZGUYCSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[5] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			JLLIDDIBOHIReflection.Descriptor,
			LMIINHHKLNLReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetKilledPunkLordMonsterDataScRsp), GetKilledPunkLordMonsterDataScRsp.Parser, new string[3] { "LKFKKGNACNP", "GPBKIHALINB", "Retcode" }, null, null, null, null)
		}));
	}
}
