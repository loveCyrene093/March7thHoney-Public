using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartPunkLordRaidScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartPunkLordRaidScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChxTdGFydFB1bmtMb3JkUmFpZFNjUnNwLnByb3RvGhFDSUtKSExNT09JSy5w";
		buffer[1] = "cm90bxoRRk5KSkNJR0pJS0MucHJvdG8iqAEKFlN0YXJ0UHVua0xvcmRSYWlk";
		buffer[2] = "U2NSc3ASIQoLRkZDRFBITUpKS0cYBCABKAsyDC5DSUtKSExNT09JSxIPCgdy";
		buffer[3] = "ZXRjb2RlGAYgASgNEhMKC0tHSkpDQUJBSE9HGAggASgDEhMKC0dEQklJTU5K";
		buffer[4] = "TEJBGAkgAygNEhMKC0dFQUxKT0pDSkZOGAwgASgIEhsKBXNjZW5lGA8gASgL";
		buffer[5] = "MgwuRk5KSkNJR0pJS0NCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[6] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			CIKJHLMOOIKReflection.Descriptor,
			FNJJCIGJIKCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartPunkLordRaidScRsp), StartPunkLordRaidScRsp.Parser, new string[6] { "FFCDPHMJJKG", "Retcode", "KGJJCABAHOG", "GDBIIMNJLBA", "GEALJOJCJFN", "Scene" }, null, null, null, null)
		}));
	}
}
