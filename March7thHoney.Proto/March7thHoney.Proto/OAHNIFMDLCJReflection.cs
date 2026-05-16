using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OAHNIFMDLCJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OAHNIFMDLCJReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFPQUhOSUZNRExDSi5wcm90bxoRSUNPSU1ITEJNRkkucHJvdG8ibwoLT0FI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "TklGTURMQ0oSEwoLUEZHTEtGQkhHS00YAiABKAgSEwoLSUxHSUFOSEVBTEYY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "CCABKAgSEwoLTkdES0JEQU1FSE0YDiABKA0SIQoLSk9FQkFQTk9MQUYYDyAD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KAsyDC5JQ09JTUhMQk1GSUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ICOIMHLBMFIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OAHNIFMDLCJ), OAHNIFMDLCJ.Parser, new string[4] { "PFGLKFBHGKM", "ILGIANHEALF", "NGDKBDAMEHM", "JOEBAPNOLAF" }, null, null, null, null)
		}));
	}
}
