using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MHMFAMHHJAAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MHMFAMHHJAAReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFNSE1GQU1ISEpBQS5wcm90byqBAQoLTUhNRkFNSEhKQUESGwoXTUhNRkFN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SEhKQUFfT0FJREdGSkxGUE8QABIbChdNSE1GQU1ISEpBQV9PR0NGS0pGRktN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "TBABEhsKF01ITUZBTUhISkFBX0tCS05NSURJTUlOEAISGwoXTUhNRkFNSEhK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "QUFfTE5ITkpHT0JPSVAQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MHMFAMHHJAA) }, null, null));
	}
}
