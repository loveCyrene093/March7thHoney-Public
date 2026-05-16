using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetStuffTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetStuffTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChJHZXRTdHVmZlR5cGUucHJvdG8q2QEKDEdldFN0dWZmVHlwZRIbChdHQVBE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "T1BGT0dFTl9CTEpFRUhGQ05DTxAAEhsKF0dBUERPUEZPR0VOX1BISkhORUlP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "Q0pNEAESGwoXR0FQRE9QRk9HRU5fR0tQR0FFR1BETkwQAhIbChdHQVBET1BG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "T0dFTl9MS0lLQkJGTlBORBADEhsKF0dBUERPUEZPR0VOX0JEQkVHTEFLT09H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "EAQSGwoXR0FQRE9QRk9HRU5fSEFQUEJHT0ZBTEcQBRIbChdHQVBET1BGT0dF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "Tl9KSktIQ0VLRE9GQxAGQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GetStuffType) }, null, null));
	}
}
