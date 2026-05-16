using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BFDGAGJDODAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BFDGAGJDODAReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFCRkRHQUdKRE9EQS5wcm90byqBAQoLQkZER0FHSkRPREESGwoXQkZER0FH";
		buffer[1] = "SkRPREFfUENQREhFTFBLRU0QABIbChdCRkRHQUdKRE9EQV9JQUpJREFNQkJK";
		buffer[2] = "QhABEhsKF0JGREdBR0pET0RBX1BFRERNRk1PRUlDEAISGwoXQkZER0FHSkRP";
		buffer[3] = "REFfTUlBR0NBQkZBS0IQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BFDGAGJDODA) }, null, null));
	}
}
