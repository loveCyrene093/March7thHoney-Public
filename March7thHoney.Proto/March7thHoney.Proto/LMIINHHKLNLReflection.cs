using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LMIINHHKLNLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LMIINHHKLNLReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFMTUlJTkhIS0xOTC5wcm90byKIAQoLTE1JSU5ISEtMTkwSEwoLT0tIRUxJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RUxOTUUYASABKAgSEgoKbW9uc3Rlcl9pZBgDIAEoDRITCgt3b3JsZF9sZXZl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "bBgHIAEoDRITCgtKTEdLTElERUxCSRgKIAEoDRIRCgljb25maWdfaWQYDCAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KA0SEwoLY3JlYXRlX3RpbWUYDSABKANCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LMIINHHKLNL), LMIINHHKLNL.Parser, new string[6] { "OKHELIELNME", "MonsterId", "WorldLevel", "JLGKLIDELBI", "ConfigId", "CreateTime" }, null, null, null, null)
		}));
	}
}
