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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CihHZXRNYXRlcmlhbFN1Ym1pdEFjdGl2aXR5RGF0YVNjUnNwLnByb3RvGhFI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "QlBGRktOTkxCQy5wcm90byJYCiJHZXRNYXRlcmlhbFN1Ym1pdEFjdGl2aXR5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "RGF0YVNjUnNwEg8KB3JldGNvZGUYAiABKA0SIQoLSUhFS09LRFBOUEgYCiAD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KAsyDC5IQlBGRktOTkxCQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { HBPFFKNNLBCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMaterialSubmitActivityDataScRsp), GetMaterialSubmitActivityDataScRsp.Parser, new string[2] { "Retcode", "IHEKOKDPNPH" }, null, null, null, null)
		}));
	}
}
