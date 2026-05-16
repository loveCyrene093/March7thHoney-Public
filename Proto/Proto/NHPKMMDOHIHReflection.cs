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
		buffer[0] = "ChFOSFBLTU1ET0hJSC5wcm90byKgAQoLTkhQS01NRE9ISUgSDwoHc2hvcF9p";
		buffer[1] = "ZBgDIAEoDRITCgtPRkFCRUdQSkJKUBgEIAEoDRITCgtBQUZMSkdQS0NESBgI";
		buffer[2] = "IAEoDRITCgtPTUdHRE1NTEJKTBgJIAMoDRITCgtOQ0dFSkVFT01GQxgLIAMo";
		buffer[3] = "DRITCgtKRERNSE1DSE5OThgNIAEoDRIXCg9zaG9wX2dvb2RzX2xpc3QYDyAD";
		buffer[4] = "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NHPKMMDOHIH), NHPKMMDOHIH.Parser, new string[7] { "ShopId", "OFABEGPJBJP", "AAFLJGPKCDH", "OMGGDMMLBJL", "NCGEJEEOMFC", "JDDMHMCHNNN", "ShopGoodsList" }, null, null, null, null)
		}));
	}
}
