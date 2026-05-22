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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CihHZXRGYW50YXN0aWNTdG9yeUFjdGl2aXR5RGF0YVNjUnNwLnByb3RvGhFG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RURFSU9JSkpKQy5wcm90byJYCiJHZXRGYW50YXN0aWNTdG9yeUFjdGl2aXR5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "RGF0YVNjUnNwEiEKC09OQUpKR0NKT0hBGAQgASgLMgwuRkVERUlPSUpKSkMS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "DwoHcmV0Y29kZRgFIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { FEDEIOIJJJCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFantasticStoryActivityDataScRsp), GetFantasticStoryActivityDataScRsp.Parser, new string[2] { "ONAJJGCJOHA", "Retcode" }, null, null, null, null)
		}));
	}
}
