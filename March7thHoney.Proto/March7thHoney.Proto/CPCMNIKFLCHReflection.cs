using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CPCMNIKFLCHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CPCMNIKFLCHReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFDUENNTklLRkxDSC5wcm90byqeAQoLQ1BDTU5JS0ZMQ0gSGwoXQ1BDTU5J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "S0ZMQ0hfS0JKQUlLSkVGQkIQABIbChdDUENNTklLRkxDSF9IUExMQ0REQkZE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "QxABEhsKF0NQQ01OSUtGTENIX0NCSUtGUEhJTEtCEAISGwoXQ1BDTU5JS0ZM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Q0hfRkJPTEpGSUJCR00QAxIbChdDUENNTklLRkxDSF9GSUVFSk5QT0hERRAE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CPCMNIKFLCH) }, null, null));
	}
}
