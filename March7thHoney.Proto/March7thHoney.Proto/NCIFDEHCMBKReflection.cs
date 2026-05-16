using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NCIFDEHCMBKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NCIFDEHCMBKReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFOQ0lGREVIQ01CSy5wcm90bxoRQ0lHS0JESUdHT0kucHJvdG8ibwoLTkNJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RkRFSENNQksSEwoLQUpBTkRQQkZFQ0sYAyABKAgSEwoLQUdKTVBOTUxFR04Y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "BCADKA0SEwoLTk1LSkJLQ0VJR1AYBSABKA0SIQoLSUhETUxIRkFFS0gYDSAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KAsyDC5DSUdLQkRJR0dPSUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { CIGKBDIGGOIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NCIFDEHCMBK), NCIFDEHCMBK.Parser, new string[4] { "AJANDPBFECK", "AGJMPNMLEGN", "NMKJBKCEIGP", "IHDMLHFAEKH" }, null, null, null, null)
		}));
	}
}
