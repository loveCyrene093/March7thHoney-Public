using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KFIHIBFBAJHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KFIHIBFBAJHReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFLRklISUJGQkFKSC5wcm90bxoRSE1KR0FETElPTkEucHJvdG8aEUlQRkFH";
		buffer[1] = "RkFQQ0NELnByb3RvGhFOTUhLRExKUEdJTC5wcm90byKLAQoLS0ZJSElCRkJB";
		buffer[2] = "SkgSEwoLUEpORkZCS0NHRU0YBCABKA0SIQoLUFBQSExIQURDUEoYByABKAsy";
		buffer[3] = "DC5ITUpHQURMSU9OQRIhCgtNT0RESUJIQ1BQRBgJIAEoCzIMLk5NSEtETEpQ";
		buffer[4] = "R0lMEiEKC0ZCT0dNQk9LUEhKGAsgASgOMgwuSVBGQUdGQVBDQ0RCFqoCE01h";
		buffer[5] = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			HMJGADLIONAReflection.Descriptor,
			IPFAGFAPCCDReflection.Descriptor,
			NMHKDLJPGILReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KFIHIBFBAJH), KFIHIBFBAJH.Parser, new string[4] { "PJNFFBKCGEM", "PPPHLHADCPJ", "MODDIBHCPPD", "FBOGMBOKPHJ" }, null, null, null, null)
		}));
	}
}
