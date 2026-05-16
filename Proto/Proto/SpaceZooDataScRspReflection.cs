using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SpaceZooDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SpaceZooDataScRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChdTcGFjZVpvb0RhdGFTY1JzcC5wcm90bxoRRE1OREpCUEdFS0cucHJvdG8a";
		buffer[1] = "EUxLSk1MUEpFUEdHLnByb3RvIugBChFTcGFjZVpvb0RhdGFTY1JzcBIPCgdy";
		buffer[2] = "ZXRjb2RlGAYgASgNEiEKC05PSkZBRkZOQkVEGAcgAygLMgwuRE1OREpCUEdF";
		buffer[3] = "S0cSEwoLTk9BR0VDQ0VFS04YCCADKA0SEwoLSExDSkVGT0pBSEsYCiADKA0S";
		buffer[4] = "EwoLRUZPQ0ZFQ0tOS0oYCyADKA0SEwoLTURBTUdNS0xMS0UYDCABKA0SEwoL";
		buffer[5] = "REtFQ0ZJTkJETksYDSADKA0SEwoLSktMR0FQR0hCSFAYDiADKA0SIQoLRE5J";
		buffer[6] = "R0dFRUZCRk4YDyADKAsyDC5MS0pNTFBKRVBHR0IWqgITTWFyY2g3dGhIb25l";
		buffer[7] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			DMNDJBPGEKGReflection.Descriptor,
			LKJMLPJEPGGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SpaceZooDataScRsp), SpaceZooDataScRsp.Parser, new string[9] { "Retcode", "NOJFAFFNBED", "NOAGECCEEKN", "HLCJEFOJAHK", "EFOCFECKNKJ", "MDAMGMKLLKE", "DKECFINBDNK", "JKLGAPGHBHP", "DNIGGEEFBFN" }, null, null, null, null)
		}));
	}
}
