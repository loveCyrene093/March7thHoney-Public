using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AOIKHPOBDGKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AOIKHPOBDGKReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFBT0lLSFBPQkRHSy5wcm90bxoRSkdQQUhMTUdCTUwucHJvdG8ipAEKC0FP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "SUtIUE9CREdLEhMKC0FCQU1ISUZFQ05QGAEgASgFEgwKBHJhbmsYAiABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "EwoLS0tDRk9JTUNMQ0QYBiABKAUSEwoLQktQREJDQUFHQUUYCiABKA0SEAoI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "c2NvcmVfaWQYDCABKA0SIQoLSk1JS1BDUElGQ0QYDSADKAsyDC5KR1BBSExN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "R0JNTBITCgtQS0FKTExJS0pQTBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { JGPAHLMGBMLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AOIKHPOBDGK), AOIKHPOBDGK.Parser, new string[7] { "ABAMHIFECNP", "Rank", "KKCFOIMCLCD", "BKPDBCAAGAE", "ScoreId", "JMIKPCPIFCD", "PKAJLLIKJPL" }, null, null, null, null)
		}));
	}
}
