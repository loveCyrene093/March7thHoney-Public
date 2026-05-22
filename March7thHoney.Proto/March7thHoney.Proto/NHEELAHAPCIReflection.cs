using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NHEELAHAPCIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NHEELAHAPCIReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFOSEVFTEFIQVBDSS5wcm90byqeAQoLTkhFRUxBSEFQQ0kSGwoXTkhFRUxB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SEFQQ0lfUENQREhFTFBLRU0QABIbChdOSEVFTEFIQVBDSV9ITElER0RMTkZI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "TRABEhsKF05IRUVMQUhBUENJX0VHRkJHSkdJRUtNEAISGwoXTkhFRUxBSEFQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Q0lfTlBEQ09KQ0FIUEUQAxIbChdOSEVFTEFIQVBDSV9HQUxHRklPTU9JTxAE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(NHEELAHAPCI) }, null, null));
	}
}
