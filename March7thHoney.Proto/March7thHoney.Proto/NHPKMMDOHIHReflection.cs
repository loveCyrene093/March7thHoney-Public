using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NHPKMMDOHIHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NHPKMMDOHIHReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFOSFBLTU1ET0hJSC5wcm90byKgAQoLTkhQS01NRE9ISUgSDwoHc2hvcF9p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "ZBgDIAEoDRITCgtPRkFCRUdQSkJKUBgEIAEoDRITCgtBQUZMSkdQS0NESBgI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "IAEoDRITCgtPTUdHRE1NTEJKTBgJIAMoDRITCgtOQ0dFSkVFT01GQxgLIAMo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "DRITCgtKRERNSE1DSE5OThgNIAEoDRIXCg9zaG9wX2dvb2RzX2xpc3QYDyAD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NHPKMMDOHIH), NHPKMMDOHIH.Parser, new string[7] { "ShopId", "OFABEGPJBJP", "AAFLJGPKCDH", "OMGGDMMLBJL", "NCGEJEEOMFC", "JDDMHMCHNNN", "ShopGoodsList" }, null, null, null, null)
		}));
	}
}
