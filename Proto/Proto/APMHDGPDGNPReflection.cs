using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class APMHDGPDGNPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static APMHDGPDGNPReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChFBUE1IREdQREdOUC5wcm90bxoRQkNJRk1IRkNETUcucHJvdG8aEUhQTUpD";
		buffer[1] = "T0NDQkpKLnByb3RvGhFLR0FCSkVOQ0ZEQy5wcm90bxoRS0hJTElGT09JR0gu";
		buffer[2] = "cHJvdG8aEVBOS0VCQkFET05KLnByb3RvItQBCgtBUE1IREdQREdOUBIhCgtM";
		buffer[3] = "UEhPQUlKRlBOUBgDIAEoCzIMLlBOS0VCQkFET05KEiEKC05MSUxOT05DTkZD";
		buffer[4] = "GAogASgLMgwuS0dBQkpFTkNGREMSJAoLS0ZQQkFDRUhBTUgY/AQgASgLMgwu";
		buffer[5] = "SFBNSkNPQ0NCSkpIABIkCgtPUERKS0tQUFBPRBiSCCABKAsyDC5CQ0lGTUhG";
		buffer[6] = "Q0RNR0gAEiQKC0NJTUdDRUVHRENGGM4NIAEoCzIMLktISUxJRk9PSUdISABC";
		buffer[7] = "DQoLQlBJSEZBSkNMT0NCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[8] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
		{
			BCIFMHFCDMGReflection.Descriptor,
			HPMJCOCCBJJReflection.Descriptor,
			KGABJENCFDCReflection.Descriptor,
			KHILIFOOIGHReflection.Descriptor,
			PNKEBBADONJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(APMHDGPDGNP), APMHDGPDGNP.Parser, new string[5] { "LPHOAIJFPNP", "NLILNONCNFC", "KFPBACEHAMH", "OPDJKKPPPOD", "CIMGCEEGDCF" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
