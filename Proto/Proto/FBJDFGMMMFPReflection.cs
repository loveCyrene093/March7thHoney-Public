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
		buffer[0] = "ChFGQkpERkdNTU1GUC5wcm90bxohR2FtZXBsYXlDb3VudGVyVXBkYXRlUmVh";
		buffer[1] = "c29uLnByb3RvImUKC0ZCSkRGR01NTUZQEiwKBnJlYXNvbhgGIAEoDjIcLkdh";
		buffer[2] = "bWVwbGF5Q291bnRlclVwZGF0ZVJlYXNvbhITCgtOTkJLUERLUElHSRgJIAEo";
		buffer[3] = "DRITCgtJQVBGQkdFREdBTRgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90";
		buffer[4] = "b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GameplayCounterUpdateReasonReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FBJDFGMMMFP), FBJDFGMMMFP.Parser, new string[3] { "Reason", "NNBKPDKPIGI", "IAPFBGEDGAM" }, null, null, null, null)
		}));
	}
}
