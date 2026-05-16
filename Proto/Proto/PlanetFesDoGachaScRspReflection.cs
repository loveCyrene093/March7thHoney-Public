using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesDoGachaScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesDoGachaScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChtQbGFuZXRGZXNEb0dhY2hhU2NSc3AucHJvdG8aEUVJS0xPQ0hQTkJNLnBy";
		buffer[1] = "b3RvGhFGQkJNREZET0VFRi5wcm90bxoRRkZCREFES0ZQQkYucHJvdG8itgEK";
		buffer[2] = "FVBsYW5ldEZlc0RvR2FjaGFTY1JzcBIPCgdyZXRjb2RlGAQgASgNEhAKCGdh";
		buffer[3] = "Y2hhX2lkGAsgASgNEiEKC0pJR0lCTExGUEtGGA4gAygLMgwuRkJCTURGRE9F";
		buffer[4] = "RUYSIwoLTUFISEVOSElIREsYASABKAsyDC5GRkJEQURLRlBCRkgAEiMKC0JC";
		buffer[5] = "TUdPRkhMRUFLGAkgASgLMgwuRUlLTE9DSFBOQk1IAEINCgtGTkpKTkFPQ09J";
		buffer[6] = "SUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			EIKLOCHPNBMReflection.Descriptor,
			FBBMDFDOEEFReflection.Descriptor,
			FFBDADKFPBFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesDoGachaScRsp), PlanetFesDoGachaScRsp.Parser, new string[5] { "Retcode", "GachaId", "JIGIBLLFPKF", "MAHHENHIHDK", "BBMGOFHLEAK" }, new string[1] { "FNJJNAOCOII" }, null, null, null)
		}));
	}
}
