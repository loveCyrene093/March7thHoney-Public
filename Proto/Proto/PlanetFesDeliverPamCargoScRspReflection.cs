using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesDeliverPamCargoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesDeliverPamCargoScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiNQbGFuZXRGZXNEZWxpdmVyUGFtQ2FyZ29TY1JzcC5wcm90bxoRSExMQ0RC";
		buffer[1] = "TENJUEsucHJvdG8aEUpJUEFDREVKS0pDLnByb3RvIokBCh1QbGFuZXRGZXNE";
		buffer[2] = "ZWxpdmVyUGFtQ2FyZ29TY1JzcBIPCgdyZXRjb2RlGAEgASgNEiEKC0lPTEtE";
		buffer[3] = "TkFNRENPGAggASgLMgwuSExMQ0RCTENJUEsSIQoLRElIRUNJSUtFTEUYCiAB";
		buffer[4] = "KAsyDC5KSVBBQ0RFSktKQxIRCglhdmF0YXJfaWQYDiABKA1CFqoCE01hcmNo";
		buffer[5] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			HLLCDBLCIPKReflection.Descriptor,
			JIPACDEJKJCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesDeliverPamCargoScRsp), PlanetFesDeliverPamCargoScRsp.Parser, new string[4] { "Retcode", "IOLKDNAMDCO", "DIHECIIKELE", "AvatarId" }, null, null, null, null)
		}));
	}
}
