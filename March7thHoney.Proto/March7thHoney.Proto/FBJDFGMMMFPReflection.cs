using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FBJDFGMMMFPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FBJDFGMMMFPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFGQkpERkdNTU1GUC5wcm90bxohR2FtZXBsYXlDb3VudGVyVXBkYXRlUmVh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "c29uLnByb3RvImUKC0ZCSkRGR01NTUZQEiwKBnJlYXNvbhgGIAEoDjIcLkdh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "bWVwbGF5Q291bnRlclVwZGF0ZVJlYXNvbhITCgtOTkJLUERLUElHSRgJIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "DRITCgtJQVBGQkdFREdBTRgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { GameplayCounterUpdateReasonReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FBJDFGMMMFP), FBJDFGMMMFP.Parser, new string[3] { "Reason", "NNBKPDKPIGI", "IAPFBGEDGAM" }, null, null, null, null)
		}));
	}
}
