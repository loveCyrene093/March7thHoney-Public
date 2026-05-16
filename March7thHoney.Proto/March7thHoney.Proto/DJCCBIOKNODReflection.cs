using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DJCCBIOKNODReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DJCCBIOKNODReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFESkNDQklPS05PRC5wcm90bxoOSXRlbUxpc3QucHJvdG8aEU5IREtMTUlN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "TEtDLnByb3RvInEKC0RKQ0NCSU9LTk9EEhMKC0JMS0FDR0JEQUhCGAEgAygN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EhkKBnJld2FyZBgHIAEoCzIJLkl0ZW1MaXN0Eg8KB3JldGNvZGUYCCABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "IQoLSU1OT0pJREpCTkcYDCABKAsyDC5OSERLTE1JTUxLQ0IWqgITTWFyY2g3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			NHDKLMIMLKCReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DJCCBIOKNOD), DJCCBIOKNOD.Parser, new string[4] { "BLKACGBDAHB", "Reward", "Retcode", "IMNOJIDJBNG" }, null, null, null, null)
		}));
	}
}
