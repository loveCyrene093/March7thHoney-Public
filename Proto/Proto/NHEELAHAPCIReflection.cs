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
		buffer[0] = "ChFOSEVFTEFIQVBDSS5wcm90byqeAQoLTkhFRUxBSEFQQ0kSGwoXTkhFRUxB";
		buffer[1] = "SEFQQ0lfUENQREhFTFBLRU0QABIbChdOSEVFTEFIQVBDSV9ITElER0RMTkZI";
		buffer[2] = "TRABEhsKF05IRUVMQUhBUENJX0VHRkJHSkdJRUtNEAISGwoXTkhFRUxBSEFQ";
		buffer[3] = "Q0lfTlBEQ09KQ0FIUEUQAxIbChdOSEVFTEFIQVBDSV9HQUxHRklPTU9JTxAE";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(NHEELAHAPCI) }, null, null));
	}
}
