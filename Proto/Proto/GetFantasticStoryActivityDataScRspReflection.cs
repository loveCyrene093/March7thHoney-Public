using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFantasticStoryActivityDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFantasticStoryActivityDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CihHZXRGYW50YXN0aWNTdG9yeUFjdGl2aXR5RGF0YVNjUnNwLnByb3RvGhFG";
		buffer[1] = "RURFSU9JSkpKQy5wcm90byJYCiJHZXRGYW50YXN0aWNTdG9yeUFjdGl2aXR5";
		buffer[2] = "RGF0YVNjUnNwEiEKC09OQUpKR0NKT0hBGAQgASgLMgwuRkVERUlPSUpKSkMS";
		buffer[3] = "DwoHcmV0Y29kZRgFIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { FEDEIOIJJJCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFantasticStoryActivityDataScRsp), GetFantasticStoryActivityDataScRsp.Parser, new string[2] { "ONAJJGCJOHA", "Retcode" }, null, null, null, null)
		}));
	}
}
