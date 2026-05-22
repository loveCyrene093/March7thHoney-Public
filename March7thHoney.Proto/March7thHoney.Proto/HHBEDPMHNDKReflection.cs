using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HHBEDPMHNDKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HHBEDPMHNDKReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFISEJFRFBNSE5ESy5wcm90bxoRRkxMRUJFSUNLQ0UucHJvdG8aEUlQTVBP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "TkFIRkJHLnByb3RvIp8BCgtISEJFRFBNSE5ESxIhCgtBS0hGRUtKTlBGRxgF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "IAMoCzIMLkZMTEVCRUlDS0NFEhQKDHRvdGFsX2RhbWFnZRgHIAEoDRIhCgtO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "S0lLRURIQUlFThgIIAMoCzIMLkZMTEVCRUlDS0NFEiEKC0RERUtMR0hQTk1F";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "GAogASgLMgwuSVBNUE9OQUhGQkcSEQoJY29zdF90aW1lGA8gASgNQhaqAhNN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			FLLEBEICKCEReflection.Descriptor,
			IPMPONAHFBGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HHBEDPMHNDK), HHBEDPMHNDK.Parser, new string[5] { "AKHFEKJNPFG", "TotalDamage", "NKIKEDHAIEN", "DDEKLGHPNME", "CostTime" }, null, null, null, null)
		}));
	}
}
