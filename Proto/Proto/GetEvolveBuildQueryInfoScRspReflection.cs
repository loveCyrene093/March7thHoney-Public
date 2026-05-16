using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetEvolveBuildQueryInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetEvolveBuildQueryInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJHZXRFdm9sdmVCdWlsZFF1ZXJ5SW5mb1NjUnNwLnByb3RvGhFDSkxKREtM";
		buffer[1] = "Q05EQS5wcm90bxoRSkNGUE9OQkRDTEcucHJvdG8idQocR2V0RXZvbHZlQnVp";
		buffer[2] = "bGRRdWVyeUluZm9TY1JzcBIhCgtITExFSVBLTUpLTRgEIAMoCzIMLkNKTEpE";
		buffer[3] = "S0xDTkRBEiEKC09JQVBIQkJEUEhMGA4gASgLMgwuSkNGUE9OQkRDTEcSDwoH";
		buffer[4] = "cmV0Y29kZRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			CJLJDKLCNDAReflection.Descriptor,
			JCFPONBDCLGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetEvolveBuildQueryInfoScRsp), GetEvolveBuildQueryInfoScRsp.Parser, new string[3] { "HLLEIPKMJKM", "OIAPHBBDPHL", "Retcode" }, null, null, null, null)
		}));
	}
}
