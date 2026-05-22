using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyGetDailyInitItemScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyGetDailyInitItemScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiNNb25vcG9seUdldERhaWx5SW5pdEl0ZW1TY1JzcC5wcm90byKuAQodTW9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "b3BvbHlHZXREYWlseUluaXRJdGVtU2NSc3ASEwoLSkJPTkhHTk5DTEUYAyAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "KA0SDwoHcmV0Y29kZRgFIAEoDRITCgtDUEZCQ0JLRkxGTRgGIAEoDRITCgtK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "RUhHRkVKQ0lGRhgHIAEoDRITCgtDSUxQSUpOT0lBRxgLIAEoAxITCgtFT0FB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "Sk1EQ0hJRBgMIAEoDRITCgtGSkJEQ05BS0lGTRgNIAEoDUIWqgITTWFyY2g3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyGetDailyInitItemScRsp), MonopolyGetDailyInitItemScRsp.Parser, new string[7] { "JBONHGNNCLE", "Retcode", "CPFBCBKFLFM", "JEHGFEJCIFF", "CILPIJNOIAG", "EOAAJMDCHID", "FJBDCNAKIFM" }, null, null, null, null)
		}));
	}
}
