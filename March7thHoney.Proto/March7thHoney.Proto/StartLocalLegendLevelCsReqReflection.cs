using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartLocalLegendLevelCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartLocalLegendLevelCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiBTdGFydExvY2FsTGVnZW5kTGV2ZWxDc1JlcS5wcm90bxoRTU1BQURPTEhN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RUoucHJvdG8iZgoaU3RhcnRMb2NhbExlZ2VuZExldmVsQ3NSZXESEwoLSU5P";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "TUZGQUlFT0EYBSABKA0SEAoIZ3JvdXBfaWQYCCABKA0SIQoLYXZhdGFyX2xp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "c3QYDyADKAsyDC5NTUFBRE9MSE1FSkIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { MMAADOLHMEJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartLocalLegendLevelCsReq), StartLocalLegendLevelCsReq.Parser, new string[3] { "INOMFFAIEOA", "GroupId", "AvatarList" }, null, null, null, null)
		}));
	}
}
