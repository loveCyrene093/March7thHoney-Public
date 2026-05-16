using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingFinishBattleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingFinishBattleCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "Ch9DaGVuTGluZ0ZpbmlzaEJhdHRsZUNzUmVxLnByb3RvGhFMS0ZOREFPR01N";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "Ty5wcm90byKNAQoZQ2hlbkxpbmdGaW5pc2hCYXR0bGVDc1JlcRITCgtQSkxB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "REdPT0ZLRRgGIAEoDRITCgtES01QRExQRUlKQhgIIAEoDRIhCgtIQUlPSEFO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "RElLSRgJIAMoCzIMLkxLRk5EQU9HTU1PEhMKC0xNSUlDRU5NT0JJGAogASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "Eg4KBmlzX3dpbhgOIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { LKFNDAOGMMOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingFinishBattleCsReq), ChenLingFinishBattleCsReq.Parser, new string[5] { "PJLADGOOFKE", "DKMPDLPEIJB", "HAIOHANDIKI", "LMIICENMOBI", "IsWin" }, null, null, null, null)
		}));
	}
}
