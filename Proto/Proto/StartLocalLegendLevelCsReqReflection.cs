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
		buffer[0] = "CiBTdGFydExvY2FsTGVnZW5kTGV2ZWxDc1JlcS5wcm90bxoRTU1BQURPTEhN";
		buffer[1] = "RUoucHJvdG8iZgoaU3RhcnRMb2NhbExlZ2VuZExldmVsQ3NSZXESEwoLSU5P";
		buffer[2] = "TUZGQUlFT0EYBSABKA0SEAoIZ3JvdXBfaWQYCCABKA0SIQoLYXZhdGFyX2xp";
		buffer[3] = "c3QYDyADKAsyDC5NTUFBRE9MSE1FSkIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[4] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MMAADOLHMEJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartLocalLegendLevelCsReq), StartLocalLegendLevelCsReq.Parser, new string[3] { "INOMFFAIEOA", "GroupId", "AvatarList" }, null, null, null, null)
		}));
	}
}
