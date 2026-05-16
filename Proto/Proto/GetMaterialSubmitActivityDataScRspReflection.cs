using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMaterialSubmitActivityDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMaterialSubmitActivityDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CihHZXRNYXRlcmlhbFN1Ym1pdEFjdGl2aXR5RGF0YVNjUnNwLnByb3RvGhFI";
		buffer[1] = "QlBGRktOTkxCQy5wcm90byJYCiJHZXRNYXRlcmlhbFN1Ym1pdEFjdGl2aXR5";
		buffer[2] = "RGF0YVNjUnNwEg8KB3JldGNvZGUYAiABKA0SIQoLSUhFS09LRFBOUEgYCiAD";
		buffer[3] = "KAsyDC5IQlBGRktOTkxCQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { HBPFFKNNLBCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMaterialSubmitActivityDataScRsp), GetMaterialSubmitActivityDataScRsp.Parser, new string[2] { "Retcode", "IHEKOKDPNPH" }, null, null, null, null)
		}));
	}
}
