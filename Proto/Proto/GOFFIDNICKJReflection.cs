using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GOFFIDNICKJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GOFFIDNICKJReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFHT0ZGSUROSUNLSi5wcm90bxoRQkZITkNGREdDTEcucHJvdG8aEUxIT0VN";
		buffer[1] = "Q0hGT0ZBLnByb3RvGhFORklLUEZCUE9NRi5wcm90bxoRUElJTElKSEZIQ0su";
		buffer[2] = "cHJvdG8isAEKC0dPRkZJRE5JQ0tKEiMKC0dKQ0pIUEVLT0RDGAEgASgLMgwu";
		buffer[3] = "UElJTElKSEZIQ0tIABIjCgtCTEFMTExOS0hBQxgCIAEoCzIMLk5GSUtQRkJQ";
		buffer[4] = "T01GSAASIwoLRkNBUEJQSExOQ0oYAyABKAsyDC5CRkhOQ0ZER0NMR0gAEiMK";
		buffer[5] = "C0pOS01KTUFCUE1QGAkgASgLMgwuTEhPRU1DSEZPRkFIAEINCgtCUElIRkFK";
		buffer[6] = "Q0xPQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			BFHNCFDGCLGReflection.Descriptor,
			LHOEMCHFOFAReflection.Descriptor,
			NFIKPFBPOMFReflection.Descriptor,
			PIILIJHFHCKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GOFFIDNICKJ), GOFFIDNICKJ.Parser, new string[4] { "GJCJHPEKODC", "BLALLLNKHAC", "FCAPBPHLNCJ", "JNKMJMABPMP" }, new string[1] { "BPIHFAJCLOC" }, null, null, null)
		}));
	}
}
