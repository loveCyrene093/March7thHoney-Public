using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MOCDFPPJIECReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MOCDFPPJIECReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFNT0NERlBQSklFQy5wcm90byqBAQoLTU9DREZQUEpJRUMSGwoXTU9DREZQ";
		buffer[1] = "UEpJRUNfUENQREhFTFBLRU0QABIbChdNT0NERlBQSklFQ19PSUxCQk5ETktC";
		buffer[2] = "QRABEhsKF01PQ0RGUFBKSUVDX0ZGTENITFBPRk5NEAISGwoXTU9DREZQUEpJ";
		buffer[3] = "RUNfQkxLQ0xJR0tGSkYQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MOCDFPPJIEC) }, null, null));
	}
}
