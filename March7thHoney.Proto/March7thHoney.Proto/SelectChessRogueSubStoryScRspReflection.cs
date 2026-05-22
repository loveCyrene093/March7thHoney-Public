using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SelectChessRogueSubStoryScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SelectChessRogueSubStoryScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiNTZWxlY3RDaGVzc1JvZ3VlU3ViU3RvcnlTY1JzcC5wcm90byKQAQodU2Vs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "ZWN0Q2hlc3NSb2d1ZVN1YlN0b3J5U2NSc3ASEwoLSUVOQktJQUdQQkEYBiAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "KA0SHwoXcm9ndWVfZGlhbG9ndWVfZXZlbnRfaWQYByABKA0SEwoLRUtFRk1O";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "UEZPR08YCyABKA0SDwoHcmV0Y29kZRgNIAEoDRITCgtGT01ORkhKQ0RPQxgO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SelectChessRogueSubStoryScRsp), SelectChessRogueSubStoryScRsp.Parser, new string[5] { "IENBKIAGPBA", "RogueDialogueEventId", "EKEFMNPFOGO", "Retcode", "FOMNFHJCDOC" }, null, null, null, null)
		}));
	}
}
