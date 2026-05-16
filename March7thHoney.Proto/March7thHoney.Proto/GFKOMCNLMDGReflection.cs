using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GFKOMCNLMDGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GFKOMCNLMDGReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFHRktPTUNOTE1ERy5wcm90byKXAQoLR0ZLT01DTkxNREcSMgoLR05LRURP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RUhOQUkYCCADKAsyHS5HRktPTUNOTE1ERy5HTktFRE9FSE5BSUVudHJ5Eg8K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "B2N1cl9udW0YCyABKA0SDwoHbWF4X251bRgPIAEoDRoyChBHTktFRE9FSE5B";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "SUVudHJ5EgsKA2tleRgBIAEoDRINCgV2YWx1ZRgCIAEoDToCOAFCFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GFKOMCNLMDG), GFKOMCNLMDG.Parser, new string[3] { "GNKEDOEHNAI", "CurNum", "MaxNum" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
